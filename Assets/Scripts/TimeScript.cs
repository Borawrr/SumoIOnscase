using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TimeScript : MonoBehaviour
{
    public float timeLeft = 60;
    public TMP_Text _timeLeft;
    public GameObject Player;
    public TMP_Text YouWin;

    // Update is called once per frame
    void Update()
    {
        timeLeft = timeLeft - Time.deltaTime;
        _timeLeft.text = ("Time Left : " )+ Mathf.FloorToInt(timeLeft).ToString();
        TimeUp();
    }

    void TimeUp()
    {
        if(timeLeft <= 0 && Player != null)
        {
            YouWin.text = ("YOU WIN !");
            Invoke("ReloadScene", 2f);
        }
    }

    void ReloadScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }


}
