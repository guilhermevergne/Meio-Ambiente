using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnBehavior : MonoBehaviour
{

    public void SceneChange()
    {

        bool CreatedChar = false;

        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            SceneManager.LoadScene("Recepcao");
        }
        else if (CreatedChar == false && SceneManager.GetActiveScene().buildIndex == 1)
        {
            SceneManager.LoadScene("Character_Creation");
            CreatedChar = true;
        }
        else if (CreatedChar == true && SceneManager.GetActiveScene().buildIndex == 1)
        {
            SceneManager.LoadScene("Refeitorio");
        }
        else if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            SceneManager.LoadScene("Recepcao");
        }
    }
}
