using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverPanel : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText, highScoreText;
    [SerializeField] private int score;
    [SerializeField] private int highScore;
    void Awake()
    {
        score = FindObjectOfType<Score>().currentScore;
        highScore = Score.highScore;
    }
    public void DrawScore()
    {
        scoreText.text = $"Score : {score}";
        highScoreText.text = $"Highscore : {highScore}";
    }
    

}
