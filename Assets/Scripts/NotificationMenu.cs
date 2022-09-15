using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotificationMenu : MonoBehaviour
{
    
    void Start()
    {
        Time.timeScale = 0;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(StartGame());
        }
    }
    IEnumerator StartGame()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        Time.timeScale = 1;
        gameObject.SetActive(false);
    }
}
            
