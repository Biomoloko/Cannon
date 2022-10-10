using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class Score : MonoBehaviour
{
    public static int highScore;
    public int currentScore = 0;
    public TMP_Text scoreText;
    
    public void ScoreCounting(int targetCost)
    {
        currentScore += targetCost;
        scoreText.text = "Score : "+currentScore;
        if (currentScore > highScore)
        {
            highScore = currentScore;
        }

    }
}
