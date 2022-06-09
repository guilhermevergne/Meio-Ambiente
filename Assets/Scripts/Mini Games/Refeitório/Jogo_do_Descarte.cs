using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jogo_do_Descarte : MonoBehaviour
{


    public void SelectLixeira(string lixeira)
    {
        if(PlayerPrefs.GetString("Selected Waste") != "")
        {
            PlayerPrefs.SetString("Selected Lixeira", lixeira);

            if (!CheckWaste())//Escolheu errado
            {
                PlayerPrefs.SetInt("Sustem", PlayerPrefs.GetInt("Sustem")-100);
            }
            DestroyImmediate(GameObject.Find(PlayerPrefs.GetString("Selected Waste")));
            PlayerPrefs.SetString("Selected Lixeira", "");
            PlayerPrefs.SetString("Selected Waste", "");
        }
    }

    public void SelectWaste(string waste)
    {
        PlayerPrefs.SetString("Selected Waste",waste);
    }

    bool CheckWaste()
    {
        string waste = PlayerPrefs.GetString("Selected Waste");
        string lixeira = PlayerPrefs.GetString("Selected Lixeira");
        if (waste == "Bedida" && lixeira == "Amarela") return true;
        if (waste == "Papelzinho" && lixeira == "Azul") return true;
        if (waste == "Comida" && lixeira == "Marrom") return true;
        if (waste == "Talheres" && lixeira == "Vermelho") return true;

        return false;
    }







    void OnTriggerEnter2D(Collider2D other)
    {
        if (/*PlayerPrefs.GetInt("Jogo do Descarte") != 1*/ true)
        {
            PlayerPrefs.SetFloat("PlayerX", GameObject.Find("Player").transform.localPosition.x);
            PlayerPrefs.SetInt("Jogo do Descarte", 1);
            SceneManager.LoadScene("Jogo do Descarte");
        }
    }
}
