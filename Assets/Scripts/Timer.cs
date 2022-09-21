using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    [SerializeField] private Image timerImage;
    [SerializeField] private float fullTime = 120;
    [SerializeField] private float time;
    [SerializeField] private GameOverPanel gameOverPanel;
    
    void Start()
    {
        gameOverPanel = FindObjectOfType<GameOverPanel>();
        StartCoroutine(TimeBeforeStartTimer());
    }

    IEnumerator TimeBeforeStartTimer()
    {
        yield return new WaitForSeconds(8f);

        while (time < fullTime)
        {
            yield return null;
            TimerWorks();
        } 
        gameOverPanel.DrawScore();
        Time.timeScale = 0;
    }
    void TimerWorks()
    {
        time += Time.deltaTime;
        timerImage.fillAmount = 1 - time / fullTime;
    }
}
