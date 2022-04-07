using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char_Instantiate : MonoBehaviour
{
    public GameObject[] characters;
    public void testar()
    {
        print(charIndex());
        if(charIndex() == -2)
        {
            print(PlayerPrefs.GetString("charGen"));
        }
        else if(charIndex() == -1)
        {
            print(PlayerPrefs.GetString("charGen"));
        }
        else
        {
            Instantiate(characters[charIndex()],transform);
        }
    }

    int charIndex()
    {
        string charGen = PlayerPrefs.GetString("charGen");
        if (charGen == "Vestimenta incompleta!") return -1;
        if (charGen == "Vestimenta inadequada!") return -2;

        if(PlayerPrefs.GetString("gender") == "M") //M
        {
            if(PlayerPrefs.GetString("color") == "B") //MB
            {
                if (PlayerPrefs.GetInt("Heads") == 1) //MBB
                {
                    return 0; //MBB
                }
                else //MBH
                {
                    return 1; //MBH
                }
            }
            else //MW
            {
                if (PlayerPrefs.GetInt("Heads") == 1) //MWB
                {
                    return 2;//MWB
                }
                else
                {
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
                    return 4; //FBL
                }
                else //MBH
                {
                    return 5; //FBS
                }
            }
            else //FW
            {
                if (PlayerPrefs.GetInt("Heads") == 1) //FWL
                {
                    return 6; //FWL
                }
                else //FWS
                {
                    return 7; //FWS
                }
            }
        }
    }

}
