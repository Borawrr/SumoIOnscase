using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GrowthPointHandlerPlayer : MonoBehaviour
{
    Vector3 scaleChange;
    [SerializeField] PushManagerAI pushManagerAI;
    public float powerUpAi;
    public float score;
    public TMP_Text scoreText;
    
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
            ScoreHandler();

        }
    }

    void Update() 
    {
        scoreText.text = ("Score : ") + score.ToString();
    }

    public void ChangePower()
    {
        powerUpAi = powerUpAi + 5;
    }
    
    public void ScoreHandler()
    {
        score = score + 100;
    }



}












