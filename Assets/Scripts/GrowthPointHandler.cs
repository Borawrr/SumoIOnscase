using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowthPointHandler : MonoBehaviour
{
    Vector3 scaleChange;
    public int maxScale;

    void Awake()
    {
        scaleChange = new Vector3(0.04f, 0.04f, 0.04f);
    }
    
    
    void Update()
    {
        
    }
    
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag==("Collectible"))
        {
            Destroy(other.gameObject);
            transform.localScale += scaleChange;
            
        }
    }
    
    
    
}
