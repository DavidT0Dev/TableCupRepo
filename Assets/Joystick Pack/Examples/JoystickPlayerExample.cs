using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickPlayerExample : MonoBehaviour
{
    public float speed;
    public VariableJoystick variableJoystick;
    public Rigidbody rb;
    public float jumpSpeed = 20;
    public float runSpeed = 5;

    public void FixedUpdate()
    {
        Vector3 direction = Vector3.forward * variableJoystick.Vertical + Vector3.right * variableJoystick.Horizontal;
        direction = new Vector3(direction.x, direction.z, direction.y); //Switch Y and Z axis to make game 2D
        //rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.Impulse);
        rb.velocity = new Vector3(20 * direction.x, 100 * direction.y, 0);
    }
}