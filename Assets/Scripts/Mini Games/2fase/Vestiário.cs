using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Vestiário : MonoBehaviour
{
    private void Start()
    {
        if (PlayerPrefs.GetInt("Vestiário") == 1)
        {
            DestroyImmediate(GameObject.Find("Vestiário"));
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
