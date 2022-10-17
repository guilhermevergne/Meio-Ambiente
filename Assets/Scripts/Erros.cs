using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Erros : MonoBehaviour
{
    public float posX;
    public float posY;
    public float speedX;
    public void OnClick(string erro)
    {
        PlayerPrefs.SetInt("erros",PlayerPrefs.GetInt("erros")+1);
        DestroyImmediate(GameObject.Find(erro));
        DestroyImmediate(GameObject.Find(erro+"Btn"));
    }
    private void FixedUpdate()
    {
        float hor = Input.GetAxisRaw("Horizontal");
        posX += hor * speedX;
        transform.localPosition = new Vector3(posX, posY, 0);
    }
}
