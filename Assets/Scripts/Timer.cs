using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text timer;
    public static float time;
    public static bool stop;
    void Start()
    {
        time = 90f;
        stop = false;
    }

    void FixedUpdate()
    {
        if (stop == false)
        {
            timer.text = time.ToString("0") ;
            time -= Time.deltaTime; 
        }
        if (LoseCheck())
        {
            PlayerPrefs.SetInt("Sustem", PlayerPrefs.GetInt("Sustem")-300);
            SceneManager.LoadScene("Corredor");
        }
        
    }

    bool LoseCheck()
    {
        if (time <= 0)
        {
            return true;
        }
        return false;
    }


}
