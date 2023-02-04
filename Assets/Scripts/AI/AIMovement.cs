using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovement : MonoBehaviour
{
    public float speed = 1 ;
    private Transform target ;
    private Rigidbody rb ;
    public bool aiDisabled = true;
 
    private void Start()
    {
        target = FindTarget();
        rb = GetComponent<Rigidbody>();
    }
     
    private void FixedUpdate()
    {
        AIMover();
    }
 
         
 
    public Transform FindTarget()
    {
        GameObject[] candidates = GameObject.FindGameObjectsWithTag("Collectible");
        float minDistance = Mathf.Infinity;
        Transform closest ;
         
        if ( candidates.Length == 0 )
        return null;
 
        closest = candidates[0].transform;
        for ( int i = 1 ; i < candidates.Length ; ++i )
        {
            float distance = (candidates[i].transform.position - transform.position).sqrMagnitude;
 
            if ( distance < minDistance )
            {
                closest = candidates[i].transform;
                minDistance = distance;
            }
        }    
        return closest;
    }    

    public void AIMover()
    {
        if(aiDisabled == true)
        {    if( target != null )
            {
                Vector3 direction = (target.position - transform.position).normalized;
                rb.MovePosition(transform.position + direction * speed * Time.deltaTime);
            }
            
            target = FindTarget();
        
        }     
    } 
}

