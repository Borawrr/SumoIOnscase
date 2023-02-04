using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushManagerPlayer : MonoBehaviour
{
    //Bu Script Yapay Zekanın ne kadar uzağa itileceğini belirtiyor
    public float push;
    AIMovement aiMovement;
    [SerializeField] GameObject ai;

    void Awake()
    {
        aiMovement = ai.GetComponent<AIMovement>();
    }

    void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag == "PlayerCharacter")
        {
            aiMovement.aiDisabled = false;
            Vector3 _direction = other.contacts[0].point - transform.position;
            _direction.y = 0;
            _direction = -_direction.normalized;
            GetComponent<Rigidbody>().AddForce(_direction * push, ForceMode.Impulse);
        }
    }

    void OnCollisionExit(Collision other)
    {
        Invoke("AIControllerEnabler", push/12);
    }

    void AIControllerEnabler()
    {
        aiMovement.aiDisabled = true;
    }

}
