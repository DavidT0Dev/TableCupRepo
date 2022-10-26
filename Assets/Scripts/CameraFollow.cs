using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    private Transform player;
    public float topY;
    public float bottomY;
    private float currentY;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
       transform.position = new Vector3(transform.position.x, GetClampedPosition(player.position.y), transform.position.z); 
    }

    float GetClampedPosition(float currentY){
        return Mathf.Clamp(currentY, bottomY, topY);
    }
}
