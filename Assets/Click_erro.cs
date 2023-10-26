using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Click_erro : MonoBehaviour
{
    public int nErros;
    public string erro;
    private void Start()
    {
        nErros = 6;
        PlayerPrefs.SetInt("erros", nErros);
    }
    public void OnMouseDown()
    {
        Debug.Log("Sprite Clicked");
        PlayerPrefs.SetInt("erros", PlayerPrefs.GetInt("erros") - 1);
        DestroyImmediate(GameObject.Find(erro));
        DestroyImmediate(GameObject.Find(erro + "Btn"));
        if(PlayerPrefs.GetInt("erros")<=0)
        {
            Timer.stop = true;
            PlayerPrefs.SetInt("Sustem", PlayerPrefs.GetInt("Sustem") + 2 * Mathf.CeilToInt(Timer.time));
            SceneManager.LoadScene("Vitoria");
        }
    }
}