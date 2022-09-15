using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private Image timerImage;
    [SerializeField] private float fullTime = 120;
    [SerializeField] private float time;
    void Start()
    {
        StartCoroutine(TimeBeforeStartTimer());
    }

    IEnumerator TimeBeforeStartTimer()
    {
        yield return new WaitForSeconds(8f);

        while (time < 120)
        {
            yield return null;
            TimerWorks();
        }
        Time.timeScale = 0;
    }
    void TimerWorks()
    {
        time += Time.deltaTime;
        timerImage.fillAmount = 1 - time / fullTime;
    }
}
