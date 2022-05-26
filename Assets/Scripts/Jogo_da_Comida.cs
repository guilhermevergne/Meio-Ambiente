using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Jogo_da_Comida : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        if (PlayerPrefs.GetInt("Jogo da Comida") == 1)
        {
            DestroyImmediate(GameObject.Find("Jogo_da_Comida"));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
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
