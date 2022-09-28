using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioVolumeChanger : MonoBehaviour
{
    public string volumeParameter = "MasterVol";
    public AudioMixer mixer;
    public Slider slider;

    private void Awake()
    {
        slider.onValueChanged.AddListener(SliderValueChanged);
    }

    private void SliderValueChanged(float value)
    {
        var volumeValue = Mathf.Lerp(-80, 0, value);
        mixer.SetFloat(volumeParameter, volumeValue);
    }
    

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
