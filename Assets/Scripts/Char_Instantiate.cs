using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char_Instantiate : MonoBehaviour
{
    public GameObject[] charColor0;
    public GameObject[] charColor1;

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
            //Instantiate(characters[charIndex()],transform);
            if (PlayerPrefs.GetInt("Color") == 0)
            {
                Instantiate(charColor0[PlayerPrefs.GetInt("Heads")], transform);
            }
            else
            {
                print(PlayerPrefs.GetInt("Heads"));
                Instantiate(charColor1[PlayerPrefs.GetInt("Heads")], transform);
            }
            
        }
    }

    int CharIndex()
    {

        /*string charGen = PlayerPrefs.GetString("charGen");
        if (charGen == "Vestimenta incompleta!") return -1;
        if (charGen == "Vestimenta inadequada!") return -2;

        if(PlayerPrefs.GetString("gender") == "M") //M
        {
            if(PlayerPrefs.GetString("color") == "B") //MB
            {
                if (PlayerPrefs.GetInt("Heads") == 1) //MBB
                {
                    PlayerPrefs.SetString("hair", "B");
                    return 0; //MBB
                }
                else //MBH
                {
                    PlayerPrefs.SetString("hair", "H");
                    return 1; //MBH
                }
            }
            else //MW
            {
                if (PlayerPrefs.GetInt("Heads") == 1) //MWB
                {
                    PlayerPrefs.SetString("hair", "B");
                    return 2;//MWB
                }
                else
                {
                    PlayerPrefs.SetString("hair", "H");
                    return 3; //MWH
                }
            }
        }
        else //F
        {
            if (PlayerPrefs.GetString("color") == "B") //FB
            {
                if (PlayerPrefs.GetInt("Heads") == 1) //FBL
                {
                    PlayerPrefs.SetString("hair", "L");
                    return 4; //FBL
                }
                else //MBH
                {
                    PlayerPrefs.SetString("hair", "S");
                    return 5; //FBS
                }
            }
            else //FW
            {
                if (PlayerPrefs.GetInt("Heads") == 1) //FWL
                {
                    PlayerPrefs.SetString("hair", "L");
                    return 6; //FWL
                }
                else //FWS
                {
                    PlayerPrefs.SetString("hair", "S");
                    return 7; //FWS
                }
            }
        }*/
        return 0;
    }
}
