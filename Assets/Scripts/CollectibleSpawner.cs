using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleSpawner : MonoBehaviour
{
    public GameObject Collectible;
    public float collectibleSpawnRate;
    public float timer;
    
    void Update()
    {
        
        Vector3 randomSpawnPosition = new Vector3(Random.Range(-17,17), 2, Random.Range(-17,17));

        if(timer < collectibleSpawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            Instantiate(Collectible, randomSpawnPosition, Quaternion.identity);
            timer = 0;
        }
    }
}
