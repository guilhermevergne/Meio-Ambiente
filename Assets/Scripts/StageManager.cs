using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageManager : MonoBehaviour
{
    public string Stage;
    public void DestroyKeys()
    {
        PlayerPrefs.DeleteKey("Jogo da Pia");
        PlayerPrefs.DeleteKey("Jogo da Comida");
        PlayerPrefs.DeleteKey("Jogo do Descarte");
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (PlayerPrefs.GetInt("Jogo do Descarte") == 1)
        {
            DestroyKeys();
            SceneManager.LoadScene(Stage);
        }
    }

    public void ChangeScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
