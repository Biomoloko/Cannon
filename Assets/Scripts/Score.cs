using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class Score : MonoBehaviour
{
    public int currentScore = 0;
    public TMP_Text scoreText;
    void Start()
    {
    }

    void Update()
    {
        
    }
    public void ScoreCounting(int targetCost)
    {
        currentScore += targetCost;
        scoreText.text = "Score : "+currentScore;
    }
}
