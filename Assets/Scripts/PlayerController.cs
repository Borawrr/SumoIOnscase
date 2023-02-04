using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public FloatingJoystick joystick;
    public float movementSpeedPlayer;
    public bool disabled = true;
    


    
    private void FixedUpdate()
    {
        
        PlayerMover();

    }

    public void PlayerMover()
    {
        if(disabled == true)
        {
            rb.velocity = new Vector3(joystick.Horizontal * movementSpeedPlayer, rb.velocity.y, joystick.Vertical * movementSpeedPlayer);
        }    
        
    }

}
