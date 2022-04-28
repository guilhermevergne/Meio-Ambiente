using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Char_Selection_Manager : MonoBehaviour
{
    public GameObject[] piecePart;
    public Sprite[] headSprite;
    public Sprite[] shirtSprite;
    public Sprite[] pantsSprite;
    public Sprite[] shoesSprite;
    public Sprite[] headSpriteSelected;
    public Sprite[] shirtSpriteSelected;
    public Sprite[] pantsSpriteSelected;
    public Sprite[] shoesSpriteSelected;

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
                charGen = "Created";
            }
        }
        DestroyImmediate(GameObject.Find("Selection(Clone)"));
        PlayerPrefs.SetString("charGen", charGen);
    }

    public void selectHead(int index)
    {
        int old = PlayerPrefs.GetInt("Head");
        GameObject.Find("Head" + old.ToString()).GetComponent<Image>().sprite = headSprite[old];
        GameObject.Find("Head" + index.ToString()).GetComponent<Image>().sprite = headSpriteSelected[index];
        PlayerPrefs.SetInt("Head", index);
        if (index == 1) index = -2;
        if (index == 2) index = 1;
        if (index == 3) index = 2;
        PlayerPrefs.SetInt("Heads", index);
    }
    public void selectShirt(int index)
    {
        int old = PlayerPrefs.GetInt("Shirt");
        GameObject.Find("Shirt" + old.ToString()).GetComponent<Image>().sprite = shirtSprite[old];
        GameObject.Find("Shirt" + index.ToString()).GetComponent<Image>().sprite = shirtSpriteSelected[index];
        PlayerPrefs.SetInt("Shirt", index);
        if (index == 0) index = -2;
        if (index == 1) index = -2;
        if (index == 2) index = 0;
        PlayerPrefs.SetInt("Shirts", index);
    }
    public void selectPants(int index)
    {
        int old = PlayerPrefs.GetInt("Pant");
        GameObject.Find("Pants" + old.ToString()).GetComponent<Image>().sprite = pantsSprite[old];
        GameObject.Find("Pants" + index.ToString()).GetComponent<Image>().sprite = pantsSpriteSelected[index];
        PlayerPrefs.SetInt("Pant", index);
        if (index == 0) index = -2;
        if (index == 1) index = 0;
        if (index == 2) index = -2;
        PlayerPrefs.SetInt("Pants", index);
    }
    public void selectShoes(int index)
    {
        int old = PlayerPrefs.GetInt("Shoe");
        GameObject.Find("Shoes" + old.ToString()).GetComponent<Image>().sprite = shoesSprite[old];
        GameObject.Find("Shoes" + index.ToString()).GetComponent<Image>().sprite = shoesSpriteSelected[index];
        PlayerPrefs.SetInt("Shoe", index);
        if (index == 0) index = -2;
        if (index == 1) index = -2;
        if (index == 2) index = 0;
        PlayerPrefs.SetInt("Shoes", index);
    }
    public void selectColor(int index)
    {
        PlayerPrefs.SetInt("Color", index);
    }



}
