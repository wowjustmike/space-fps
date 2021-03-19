using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateAroundTunnel : MonoBehaviour
{
    public int speed;
    public InputManager input;
    public Transform tunnel;
    void Update()
    {
        if (!FindObjectOfType<GroundCheck>().hitWall)
        {
            tunnel.Rotate(new Vector3(0,1,0),input.x*speed*Time.deltaTime);
        }
        else
        {
            tunnel.Rotate(new Vector3(0,1,0),input.x*-speed*Time.deltaTime);
        }
    }
}
