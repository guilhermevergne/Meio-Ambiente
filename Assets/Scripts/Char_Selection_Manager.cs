using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char_Selection_Manager : MonoBehaviour
{
    public GameObject[] piecePart;
    Dictionary<string, int> part = new Dictionary<string, int> {
        {"Heads", 0 },
        {"Shirts", 1 },
        {"Pants", 2 },
        {"Shoes", 3 }
    };

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetString("pressed", "");
        setHeads();
        setShirts();
        setShirts();
        setShoes();
    }

    void setHeads()
    {
        PlayerPrefs.SetInt("Heads", -1);
        PlayerPrefs.SetInt("MHeads1", 1);
        PlayerPrefs.SetInt("MHeads2", 1);
    }

    void setShirts()
    {
        PlayerPrefs.SetInt("Shirts", -1);
        PlayerPrefs.SetInt("MShirts0", 1);
    }

    void setPants()
    {
        PlayerPrefs.SetInt("Pants", -1);
        PlayerPrefs.SetInt("MPants0", 1);
    }

    void setShoes()
    {
        PlayerPrefs.SetInt("Shoes", -1);
        PlayerPrefs.SetInt("MShoes1", 1);
    }



    /*
    public void selectColor(string color)
    {
        PlayerPrefs.SetString("color", color);
    }
    
    public void selectGender(string gender)
    {
        PlayerPrefs.SetString("gender", gender);
    }
    
    public void selectPart(string piece)
    {
        PlayerPrefs.SetString("piece", piece);
        if (PlayerPrefs.GetString("pressed") == piece)
        {
            PlayerPrefs.SetString("pressed", "");
            DestroyImmediate(GameObject.Find(piece + "(Clone)"));
        }
        else if(PlayerPrefs.GetString("pressed") == "")
        {
            PlayerPrefs.SetString("pressed", piece);
            Instantiate(piecePart[part[piece]],transform);
        }
    }
    /*
    public void selectPiece(int nButton)
    {
        string piece = PlayerPrefs.GetString("pressed");
        string gender = PlayerPrefs.GetString("gender");
        if (PlayerPrefs.GetInt(gender+piece+nButton.ToString()) == 0)
        {
            PlayerPrefs.SetInt(piece, -2);
        }
        else
        {
            PlayerPrefs.SetInt(piece,nButton);
        }
    }*/

    public void finish()
    {
        string charGen = "";
        string[] parts = new string[] {
        "Heads",
        "Shirts",
        "Pants",
        "Shoes" };
        foreach(string part in parts)
        {
            if(PlayerPrefs.GetInt(part) == -1)
            {
                charGen = "Vestimenta incompleta!";
                break;
            }
            else if (PlayerPrefs.GetInt(part) == -2)
            {
                charGen = "Vestimenta inadequada!";
                break;
            }
            else
            {
                charGen += PlayerPrefs.GetInt(part).ToString();
            }
        }
        PlayerPrefs.SetString("charGen", charGen);
    }

    public void selectHead(int index)
    {
        PlayerPrefs.SetInt("Heads", index);
    }
    public void selectShirt(int index)
    {
        PlayerPrefs.SetInt("Shirts", index);
    }
    public void selectPants(int index)
    {
        PlayerPrefs.SetInt("Pants", index);
    }
    public void selectShoes(int index)
    {
        PlayerPrefs.SetInt("Shoes", index);
    }
    public void selectColor(int index)
    {
        PlayerPrefs.SetInt("Color", index);
    }



}
