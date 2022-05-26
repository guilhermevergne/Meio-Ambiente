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
        if (PlayerPrefs.GetInt("Jogo da Pia") == 1)
        {
            DestroyImmediate(GameObject.Find("Jogo_da_Pia"));
        }
    }

    void ChangeBtn()
    {
        GameObject.Find("Btn0").GetComponent<Image>().sprite = Dryer[0];
        GameObject.Find("Btn1").GetComponent<Image>().sprite = Dryer[1];
        GameObject.Find("Btn2").GetComponent<Image>().sprite = Dryer[2];
    }

    public void SelectSinkAndDryer(int button)
    {
        int sustem = PlayerPrefs.GetInt("Sustem");
        if (!sinkSelected)
        {
            PlayerPrefs.SetInt("Sink", button);
            sinkSelected = true;
            if (button == 0)
            {
                PlayerPrefs.SetInt("Pia Certa", 1);
            }
            else
            {
                sustem -= 250;
            }
            ChangeBtn();
        }
        else
        {
            PlayerPrefs.SetInt("Dryer", button);
            if (button == 1)
            {
                PlayerPrefs.SetInt("Secador Certo", 1);
            }
            else
            {
                sustem -= 250;
            }
            SceneManager.LoadScene("Refeitorio");
        }
        PlayerPrefs.SetInt("Sustem", sustem);
    }

    public void SelectDryer(int button)
    {
        if (sinkSelected)
        {
            PlayerPrefs.SetInt("Dryer", button);
            if (button == 1)
            {
                PlayerPrefs.SetInt("Secador Certo", 1);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(PlayerPrefs.GetInt("Jogo da Pia") != 1)
        {
            PlayerPrefs.SetFloat("PlayerX", GameObject.Find("Player").transform.localPosition.x);
            PlayerPrefs.SetInt("Jogo da Pia", 1);
            SceneManager.LoadScene("Jogo da Pia");
        }
    }

}
