using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushHandler : MonoBehaviour
{
    AIMovement AImover;
    public float push;
    public Rigidbody rbplayer;

    void Start()
    {
        rbplayer = GetComponent<Rigidbody>();
        AImover = GetComponent<AIMovement>();
    }


    void OnCollisionEnter(Collision collision) 
    {
        if(collision.gameObject.CompareTag("AI"))
        {
            // collision.gameObject.GetComponent<AIMovement>().enabled = false;
            rbplayer.AddForce(-transform.position * push, ForceMode.Impulse);
        }
    }

    void OnCollisionExit(Collision collision)
    {
        // Invoke(gameObject.GetComponent<AIMovement>().enabled = true, 1f);
    }


    
}
