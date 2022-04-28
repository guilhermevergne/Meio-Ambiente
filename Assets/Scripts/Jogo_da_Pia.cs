using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Jogo_da_Pia : MonoBehaviour
{
    public Sprite[] Sink;
    public Sprite[] Dryer;
    bool sinkSelected;

    private void Start()
    {
        PlayerPrefs.DeleteKey("Sink");
        PlayerPrefs.DeleteKey("Dryer");
        sinkSelected = false;
    }

    void ChangeBtn()
    {
        GameObject.Find("Btn0").GetComponent<Image>().sprite = Dryer[0];
        GameObject.Find("Btn1").GetComponent<Image>().sprite = Dryer[1];
        GameObject.Find("Btn2").GetComponent<Image>().sprite = Dryer[2];
    }

    public void SelectSink(int button)
    {
        if (!sinkSelected)
        {
            PlayerPrefs.SetInt("Sink", button);
            sinkSelected = true;
            ChangeBtn();
        }
        else
        {
            PlayerPrefs.SetInt("Dryer", button);
            SceneManager.LoadScene("Refeitorio");
        }
    }

    public void SelectDryer(int button)
    {
        if (sinkSelected)
        {
            PlayerPrefs.SetInt("Dryer", button);
            SceneManager.LoadScene("Refeitorio");
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(PlayerPrefs.GetInt("Jogo da Pia") != 1)
        {
            PlayerPrefs.SetInt("Jogo da Pia", 1);
            SceneManager.LoadScene("Jogo da Pia");
        }
    }

}
