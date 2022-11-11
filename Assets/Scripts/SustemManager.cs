using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SustemManager : MonoBehaviour
{
    public Text SustemDisplay;

    public void Update()
    {
        SustemDisplay.text = PlayerPrefs.GetInt("Sustem").ToString();
        if (PlayerPrefs.GetInt("Sustem") <= 0 && !SceneManager.GetActiveScene().name.Equals("Game Over") )
        {
            SceneManager.LoadScene("Game Over");
        }
    }

    public void SustemAdd(int i)
    {
        PlayerPrefs.SetInt("Sustem", PlayerPrefs.GetInt("Sustem") + i);
    }

}
