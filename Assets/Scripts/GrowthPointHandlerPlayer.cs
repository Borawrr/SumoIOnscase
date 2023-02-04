using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowthPointHandlerPlayer : MonoBehaviour
{
    Vector3 scaleChange;
    [SerializeField] PushManagerAI pushManagerAI;
    float powerUpAi;
    
    
    void Awake()
    {
        powerUpAi = GetComponent<PushManagerAI>().pushPlayer;
        scaleChange = new Vector3(0.04f, 0.04f, 0.04f);
    }
    
    
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag==("Collectible"))
        {
            Destroy(other.gameObject);
            transform.localScale += scaleChange;
            ChangePower();
        }
    }

    public void ChangePower()
    {
        powerUpAi = powerUpAi + 5;
    }
    



}












