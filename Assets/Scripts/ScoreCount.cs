using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreCount : MonoBehaviour
{

    TMP_Text scoreText;
    public int score = 0;
    public GameObject clearPanel;
    public TMP_Text clearText;
    public GameObject continueButton;

    public bool IsContinueClick = false;

    void Start()
    {
        scoreText = GetComponentInChildren<TMP_Text>();
        scoreText.text = "Start!";


        clearPanel.SetActive(false);
        //continueButton.SetActive(true);
    }

    
    void Update()
    {
        if(score == 0)
        {
            clearPanel.SetActive(false);
        }
        else
        {
            if (IsContinueClick == false && score % 50 == 0)
            {
                Time.timeScale = 0;
                clearPanel.SetActive(true);
                clearText.text = "You got " + score.ToString() + " points!";
                

            } else if (score % 50 != 0)
            {
                IsContinueClick = false;
                //continueButton.SetActive(true);
            }
        }

        if(score > 0)
        {
            scoreText.text = score.ToString() + " points!";
        }

    }


    public void GameContinue()
    {
        IsContinueClick = true;
        clearPanel.SetActive(false);
        Time.timeScale = 1;
    }

    
}
