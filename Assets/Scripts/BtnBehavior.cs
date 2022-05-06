using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class BtnBehavior : MonoBehaviour
{
    void Clock()
    {
        SceneManager.LoadScene(1);
    }

    private VideoPlayer video;

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
            timer = 5f;

            Invoke("Clock", timer);

            video.Play();

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
            if(PlayerPrefs.GetString("charGen") == "Created")
            {
                SceneManager.LoadScene("Recepcao");
                Ui_assistant2.charcreate = true;
            }
            else
            {
                print("Escolha um vestimenta adequada!");
            }
        }
    }

    public void Start()
    {
        video = transform.Find("Transition_Video").GetComponent<VideoPlayer>();
    }

}
