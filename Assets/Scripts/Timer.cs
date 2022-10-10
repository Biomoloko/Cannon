using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    [SerializeField] private Image timerImage;
    [SerializeField] private float fullTime;
    [SerializeField] private float time;
    [SerializeField] private GameOverPanel gameOverPanel;
    [SerializeField] bool halfTime = false;

    public static UnityEvent OnHalfTimer = new UnityEvent();

    void Start()
    {
        gameOverPanel = FindObjectOfType<GameOverPanel>(true);
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
        gameOverPanel.gameObject.SetActive(true);
    }
    void TimerWorks()
    {
        time += Time.deltaTime;
        timerImage.fillAmount = 1 - time / fullTime;
        if (time >= fullTime/2 && halfTime == false)
        {
            OnHalfTimer.Invoke();
            halfTime = true;
        }
    }
}
