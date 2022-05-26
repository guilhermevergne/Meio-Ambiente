using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitializePrefs : MonoBehaviour
{
    void Start()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetInt("Sustem", 1000);
    }

    void Update()
    {
        
    }
}
