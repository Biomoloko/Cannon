using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverPanel : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText, highScoreText;
    public int currentScore;
    private Score score;

    private void OnEnable()
    {
        score = FindObjectOfType<Score>();

        scoreText.text = $"Score : {score.currentScore}";
        highScoreText.text = $"Best Score : {Score.highScore}";
        Time.timeScale = 0;
    }
}
