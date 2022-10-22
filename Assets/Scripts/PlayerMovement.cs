using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Joystick joystick;
    public float speed;
    public float jumpForce;
    private Rigidbody myRB;
    private Collider myCol;
    private float moveX;
    private float moveY;
    private bool grounded;
    

    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody>();
        myCol = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckForInput();
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    void CheckForInput(){
        moveX = joystick.Horizontal;
        moveY = joystick.Vertical;
        grounded = IsGrounded();
    }

    void MovePlayer(){

        //Handles player movement (Player moves 1/2 speed while in the air)
        if(moveX >= .2f){
            if(grounded){
                myRB.velocity = new Vector3(speed, myRB.velocity.y, 0);
            }else{
                myRB.velocity = new Vector3(speed/2, myRB.velocity.y, 0);
            }
        }else if(moveX <= -.2f){
            if(grounded){
                myRB.velocity = new Vector3(-speed, myRB.velocity.y, 0);
            }else{
                myRB.velocity = new Vector3(-speed/2, myRB.velocity.y, 0);        
            } 
        }else{
            myRB.velocity = new Vector3(0, myRB.velocity.y, 0);
        }


        if(moveY >= .5f && grounded){
            Jump();
        }


    }

    void Jump(){
        myRB.velocity = new Vector3(myRB.velocity.x, jumpForce, 0);
    }

    //Performs a simple raycast ground check
    bool IsGrounded(){
        Color myColor;
        bool hit;
        
        if(Physics.Raycast(myCol.bounds.center, Vector3.down, myCol.bounds.extents.y + .05f)){
            myColor = Color.green;
            hit = true;
        }else{
            myColor = Color.red;
            hit = false;
        }

        Debug.DrawRay(myCol.bounds.center, Vector3.down * (myCol.bounds.extents.y + .05f), myColor);
        return hit;
    }
}
