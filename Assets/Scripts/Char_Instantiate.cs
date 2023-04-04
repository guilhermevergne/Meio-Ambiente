using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char_Instantiate : MonoBehaviour
{
    public GameObject[] charColor0;
    public GameObject[] charColor1;
    public GameObject player;

    public void Start()
    {
        Testar();
    }

    public void Testar()
    {
        if(PlayerPrefs.GetString("charGen") == "Vestimenta Inadequada!")
        {
            print(PlayerPrefs.GetString("charGen"));

            PlayerPrefs.SetString("gender", "M");
            PlayerPrefs.SetString("color", "B");
            PlayerPrefs.SetString("hair", "B");
            Instantiate(charColor0[0], transform);
        }
        else if(PlayerPrefs.GetString("charGen") == "Vestimenta incompleta!")
        {
            print(PlayerPrefs.GetString("charGen"));

            PlayerPrefs.SetString("gender", "M");
            PlayerPrefs.SetString("color", "B");
            PlayerPrefs.SetString("hair", "B");
            Instantiate(charColor0[0], transform);
        }
        else
        {
            if(PlayerPrefs.GetInt("Jogo da Pia") == 1)
            {
                player.transform.localPosition = new Vector3(PlayerPrefs.GetFloat("PlayerX"),
                    player.transform.localPosition.y, player.transform.localPosition.z);
            }
            
            //Instantiate(characters[charIndex()],transform);
            if (PlayerPrefs.GetInt("Color") == 0)
            {
                Instantiate(charColor0[PlayerPrefs.GetInt("Heads")], transform);
            }
            else
            {
                Instantiate(charColor1[PlayerPrefs.GetInt("Heads")], transform);
            }
            
        }
    }
}
