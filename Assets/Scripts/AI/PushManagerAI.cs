using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushManagerAI : MonoBehaviour
{
    //Bu Script Oyuncunun ne kadar uzağa itileceğini belirliyor

    public float pushPlayer;
    PlayerController playerController;
    [SerializeField] GameObject player;
    
    void Awake()
    {
        playerController = player.GetComponent<PlayerController>();
    }
    

    void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.tag == "AI")
        {
            playerController.disabled = false;
            Vector3 _direction = other.contacts[0].point - transform.position;
            _direction.y = 0;
            _direction = -_direction.normalized;
            GetComponent<Rigidbody>().AddForce(_direction * pushPlayer, ForceMode.Impulse);
        }
    }

    void OnCollisionExit(Collision other) 
    {
        Invoke("ControllerEnabler", pushPlayer/70);   
    }


    void ControllerEnabler()
    {
        playerController.disabled = true;
    }
}
