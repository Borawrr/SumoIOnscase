using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreDisplayer : MonoBehaviour
{
    
    public TMP_Text scoreText;
    [SerializeField] GrowthPointHandlerPlayer growthPointHandlerPlayer;
    [SerializeField] GameObject player;
    public float _scoreUp;

    
    // Update is called once per frame
    void Awake()
    {
        _scoreUp = GetComponent<GrowthPointHandlerPlayer>().score;
    }

    void Update()
    {
        scoreText.text = ("Score :") + _scoreUp.ToString();
        // Debug.Log(_scoreUp);
    }

}
