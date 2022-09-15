using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCanvas : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textMeshProUGUI;
    
    public void Drawler(string neededText)
    {
        textMeshProUGUI.text = neededText;
    }
}
