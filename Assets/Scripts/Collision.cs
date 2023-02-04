using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    public float scaleMultiplier;
    public float push;
    public Rigidbody rbplayer;

    void Start()
    {
        rbplayer = GetComponent<Rigidbody>();
    }


    void OnCollisionEnter(Collision collision) 
    {
        if(collision.gameObject.CompareTag("AI"))
        {
            rbplayer.AddForce(-transform.forward * push, ForceMode.Impulse);
        }
    }


    






}
