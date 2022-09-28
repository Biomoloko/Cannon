using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXLoadCannon : MonoBehaviour
{
    void Start()
    {
        
    }

    public void PLayCannonLoadSound()
    {
        AudioManager.instance.PlayReloadSound();
    }
}
