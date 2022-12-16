using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Vestiário : MonoBehaviour
{
    public int perda;
    static int escolhas = 3;
    private void Start()
    {
        escolhas = 3;
        if (PlayerPrefs.GetInt("Vestiário") == 1)
        {
            DestroyImmediate(GameObject.Find("Vestiário"));
        }
    }

    public void Choose(string btn)
    {
        escolhas--;
        if(btn=="Jaleco")
        {
            DestroyImmediate(GameObject.Find("Btn Jaleco"));
            DestroyImmediate(GameObject.Find("Btn Jaleco Descartavel"));
        }
        else if (btn == "Jaleco Descartavel")
        {
            PlayerPrefs.SetInt("Sustem", PlayerPrefs.GetInt("Sustem") - perda);
            DestroyImmediate(GameObject.Find("Btn Jaleco"));
            DestroyImmediate(GameObject.Find("Btn Jaleco Descartavel"));
        }
        else if (btn == "Luvas")
        {
            DestroyImmediate(GameObject.Find("Btn Luvas"));
            DestroyImmediate(GameObject.Find("Btn Luvas Descartaveis"));
        }
        else if (btn == "Luvas Descartaveis")
        {
            PlayerPrefs.SetInt("Sustem", PlayerPrefs.GetInt("Sustem") - perda);
            DestroyImmediate(GameObject.Find("Btn Luvas"));
            DestroyImmediate(GameObject.Find("Btn Luvas Descartaveis"));
        }
        else if (btn == "Oculos")
        {
            DestroyImmediate(GameObject.Find("Btn Oculos"));
        }
    }
    
    public void Finish(string scene)
    {
        if (escolhas <= 0)
        {
            SceneManager.LoadScene(scene);
        }
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (PlayerPrefs.GetInt("Vestiário") != 1)
        {
            PlayerPrefs.SetFloat("PlayerX", GameObject.Find("Player").transform.localPosition.x);
            PlayerPrefs.SetInt("Vestiário", 1);
            SceneManager.LoadScene("Vestiário");
        }
    }
}
