using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScriptAI : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag==("Destroyer"))
        {
            Destroy(collision.gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag==("AI"))
        {
            Destroy(other.gameObject);
        }
    }
}
