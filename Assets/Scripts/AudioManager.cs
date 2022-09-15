using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public AudioSource shootAudio;
    public AudioSource reloadCannon;
    public AudioSource getShot;

    public static AudioManager instance;
    void Start()
    {
        instance = this;
    }

    public void PlayReloadSound()
    {
        reloadCannon.Play();
    }
}
