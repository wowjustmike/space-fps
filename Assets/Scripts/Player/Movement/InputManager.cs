using System;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public float x;
    public float y;
    public bool Jumping;
    public bool jumpUp;
    public bool jumpDown;

    private void Update()
    {
        Jumping = Input.GetKey(KeyCode.Space);
        jumpDown = Input.GetKeyDown(KeyCode.Space);
        jumpUp = Input.GetKeyUp(KeyCode.Space);
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
    }
}
