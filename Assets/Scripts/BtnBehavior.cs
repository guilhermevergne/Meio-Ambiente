using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class BtnBehavior : MonoBehaviour
{
    void Clock()
    {
        SceneManager.LoadScene(1);
    }

    public void SceneChange()
    {
        bool CreatedChar = false;
        float timer;
        

        if (CreatedChar == false && SceneManager.GetActiveScene().buildIndex == 0)
        {
            timer = 3.5f;
            Invoke("Clock", timer);
        }
        else if (CreatedChar == false && SceneManager.GetActiveScene().buildIndex == 1)
        {
            SceneManager.LoadScene("Character_Creation");
            CreatedChar = true;
        }
        else if (CreatedChar == true && SceneManager.GetActiveScene().buildIndex == 1)
        {
            SceneManager.LoadScene("Refeitorio");
        }
        else if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            SceneManager.LoadScene("Recepcao");
        }
    }
    
}
