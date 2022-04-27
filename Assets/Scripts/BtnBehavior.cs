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


    public GameObject charSelection;
    public void InstantiateSelection()
    {
        Instantiate(charSelection, transform);
    }

    public void SceneChange()
    {
        float timer;
        

        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            timer = 3.5f;
            Invoke("Clock", timer);
        }
        /*else if (Ui_assistant2.charcreate == false && SceneManager.GetActiveScene().buildIndex == 1)
        {
            SceneManager.LoadScene("Character_Creation");
            
        }*/
        else if (/*Ui_assistant2.charcreate == true*/PlayerPrefs.GetString("charGen") == "Created" && SceneManager.GetActiveScene().buildIndex == 1)
        {
            SceneManager.LoadScene("Refeitorio");
        }
        else if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            SceneManager.LoadScene("Recepcao");
            Ui_assistant2.charcreate = true;
        }
    }
    
}
