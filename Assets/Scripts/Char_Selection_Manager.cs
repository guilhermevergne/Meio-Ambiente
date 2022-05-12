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

    public Sprite[] imgHead0;
    public Sprite[] imgShirt0;
    public Sprite[] imgPants0;
    public Sprite[] imgShoes0;

    public Sprite[] imgHead1;
    public Sprite[] imgShirt1;
    public Sprite[] imgPants1;
    public Sprite[] imgShoes1;



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
        setAvatar();
        Debug.Log("xablau");
    }

    void setAvatar()
    {
        setAvatarHead(PlayerPrefs.GetInt("Head"));
        setAvatarShirt(PlayerPrefs.GetInt("Shirt"));
        setAvatarPants(PlayerPrefs.GetInt("Pant"));
        setAvatarShoes(PlayerPrefs.GetInt("Shoe"));
    }
    

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
                charGen = "Vestimenta inadequada!";
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
        DestroyImmediate(GameObject.Find("Selection 2(Clone)"));
        DestroyImmediate(GameObject.Find("Selection 3(Clone)"));
        PlayerPrefs.SetString("charGen", charGen);
        Debug.Log(PlayerPrefs.GetString("charGen"));
    }

    void setAvatarHead(int index)
    {
        if (PlayerPrefs.GetInt("Color") == 0)
        {
            GameObject.Find("Head").GetComponent<Image>().sprite = imgHead0[PlayerPrefs.GetInt("Head")];
        }
        else if (PlayerPrefs.GetInt("Color") == 1)
        {
            GameObject.Find("Head").GetComponent<Image>().sprite = imgHead1[PlayerPrefs.GetInt("Head")];
        }
    }

    void setAvatarShirt(int index)
    {
        if (PlayerPrefs.GetInt("Color") == 0)
        {
            GameObject.Find("Shirt").GetComponent<Image>().sprite = imgShirt0[PlayerPrefs.GetInt("Shirt")];
        }
        else if (PlayerPrefs.GetInt("Color") == 1)
        {
            GameObject.Find("Shirt").GetComponent<Image>().sprite = imgShirt1[PlayerPrefs.GetInt("Shirt")];
        }
    }

    void setAvatarPants(int index)
    {
        if (PlayerPrefs.GetInt("Color") == 0)
        {
            GameObject.Find("Pants").GetComponent<Image>().sprite = imgPants0[PlayerPrefs.GetInt("Pant")];
        }
        else if (PlayerPrefs.GetInt("Color") == 1)
        {
            GameObject.Find("Pants").GetComponent<Image>().sprite = imgPants1[PlayerPrefs.GetInt("Pant")];
        }
    }

    void setAvatarShoes(int index)
    {
        if (PlayerPrefs.GetInt("Color") == 0)
        {
            GameObject.Find("Shoes").GetComponent<Image>().sprite = imgShoes0[PlayerPrefs.GetInt("Shoe")];
        }
        else if (PlayerPrefs.GetInt("Color") == 1)
        {
            GameObject.Find("Shoes").GetComponent<Image>().sprite = imgShoes1[PlayerPrefs.GetInt("Shoe")];
        }
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
        setAvatar();
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
        setAvatar();
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
        setAvatar();
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
        setAvatar();
    }
    public void selectColor(int index)
    {
        PlayerPrefs.SetInt("Color", index);
        setAvatar();
        /*
        selectHead(PlayerPrefs.GetInt("Head"));
        selectShirt(PlayerPrefs.GetInt("Shirt"));
        selectPants(PlayerPrefs.GetInt("Pant"));
        selectShoes(PlayerPrefs.GetInt("Shoe"));
        */

    }



}
