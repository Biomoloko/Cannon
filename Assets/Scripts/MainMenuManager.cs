using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] Image blackImage;
    [SerializeField] float basicOpacity;
    public void Start()
    {
        basicOpacity = Mathf.Clamp(255, 0, 1);

        if (SceneManager.GetActiveScene().name == "MainMenu")
        {
            blackImage.gameObject.SetActive(true);
            blackImage.color = new Color(0, 0, 0, 255);
        }
    }

    private void FixedUpdate()
    {
        LightningBlackImage();
    }
    public void loadFirstScene()
    {
        SceneManager.LoadScene(1);
    }

    
    public void LightningBlackImage()
    {
        basicOpacity -= Time.deltaTime;
        blackImage.color = new Color(0, 0, 0,basicOpacity);
        if (blackImage.color.a <= 0)
        {
            blackImage.gameObject.SetActive(false);
        }
    }
}
