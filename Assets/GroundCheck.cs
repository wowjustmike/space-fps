using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public bool hitWall;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("collided");
        hitWall = true;    
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("UnCollided");
        hitWall = false;
    }
}
