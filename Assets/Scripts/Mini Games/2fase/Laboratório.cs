using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Laboratório : MonoBehaviour
{
    private void Start()
    {
        if (PlayerPrefs.GetInt("Laboratório") == 1)
        {
            DestroyImmediate(GameObject.Find("Laboratório"));
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (PlayerPrefs.GetInt("Laboratório") != 1)
        {
            PlayerPrefs.SetFloat("PlayerX", GameObject.Find("Player").transform.localPosition.x);
            PlayerPrefs.SetInt("Laboratório", 1);
            SceneManager.LoadScene("Laboratório");
        }
    }
}
