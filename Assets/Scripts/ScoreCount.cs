using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreCount : MonoBehaviour
{

    TMP_Text scoreText;
    public int score = 0;

    void Start()
    {
        scoreText = GetComponentInChildren<TMP_Text>();
        scoreText.text = "Start!";
    }

    
    void Update()
    {
        if(score > 0)
        {
            scoreText.text = score.ToString() + " points!";
        }
      
    }
}
