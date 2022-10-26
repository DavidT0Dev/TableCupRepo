using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPlatforms : MonoBehaviour
{

    private Rigidbody player;
    private Collider myCol;

    // Start is called before the first frame update
    void Start()
    {
       player = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>(); 
       myCol = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
      if(player.velocity.y >= 0){
        myCol.enabled = false;
      }else{
        myCol.enabled = true;
      }
    }
}
