using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Jogo_da_Comida : MonoBehaviour
{


    public void SelectTalher(string talher)
    {
        if(PlayerPrefs.GetString("Talher") == "")
        {
            PlayerPrefs.SetString("Talher", talher);
            if (talher == "Descartavel")
            {
                PlayerPrefs.SetInt("Sustem", PlayerPrefs.GetInt("Sustem") -100);
            }
        }
        EndMiniGame();
    }

    public void SelectGuardanapo(string guardanapo)
    {
        if (PlayerPrefs.GetString("Guardanapo") == "")
        {
            PlayerPrefs.SetString("Guardanapo", guardanapo);
            if (guardanapo == "Descartavel")
            {
                PlayerPrefs.SetInt("Sustem", PlayerPrefs.GetInt("Sustem") -50);
            }
        }
        EndMiniGame();
    }


    void EndMiniGame()
    {
        if(PlayerPrefs.GetString("Talher") != "" && PlayerPrefs.GetString("Guardanapo") != "")
        {
            SceneManager.LoadScene("Refeitorio");
        }
    }









    // Start is called before the first frame update
    void Start()
    {

        if (PlayerPrefs.GetInt("Jogo da Comida") == 1)
        {
            DestroyImmediate(GameObject.Find("Jogo_da_Comida"));
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (PlayerPrefs.GetInt("Jogo da Comida") != 1)
        {
            PlayerPrefs.SetFloat("PlayerX", GameObject.Find("Player").transform.localPosition.x);
            PlayerPrefs.SetInt("Jogo da Comida", 1);
            SceneManager.LoadScene("Jogo da Comida");
        }
    }

}
