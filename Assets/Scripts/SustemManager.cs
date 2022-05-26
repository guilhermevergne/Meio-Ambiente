using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SustemManager : MonoBehaviour
{
    public Text SustemDisplay;

    public void Update()
    {
        SustemDisplay.text = PlayerPrefs.GetInt("Sustem").ToString();
    }
}
