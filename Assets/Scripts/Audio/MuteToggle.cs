using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MuteToggle : MonoBehaviour
{
    public string volumeParameter = "MasterVol";
    public AudioMixer mixer;
    public Toggle muteToggle;

    private void Start()
    {
        muteToggle = GetComponent<Toggle>();
    }
    public void muteMusic()
    {
        if (muteToggle.isOn)
        {
            mixer.SetFloat(volumeParameter, -80);
        }
        else
        {
            mixer.SetFloat(volumeParameter, 0);
        }
    }

}
