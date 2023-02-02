using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public FixedJoystick joystick;
    public float movementSpeedPlayer;


    
    private void FixedUpdate()
    {
        
        rb.velocity = new Vector3(joystick.Horizontal * movementSpeedPlayer, rb.velocity.y, joystick.Vertical * movementSpeedPlayer);

    }
}
