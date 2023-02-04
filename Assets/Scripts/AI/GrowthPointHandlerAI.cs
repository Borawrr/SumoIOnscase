using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowthPointHandlerAI : MonoBehaviour
{
    Vector3 scaleChange;
    [SerializeField] PushManagerPlayer pushManagerPlayer;
    float powerUp;
    
    
    
    void Awake()
    {
        powerUp = GetComponent<PushManagerPlayer>().push;
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
        powerUp = powerUp + 1;
    }


    
}

