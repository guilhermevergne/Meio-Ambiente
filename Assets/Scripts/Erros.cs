using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Erros : MonoBehaviour
{
    public float posX;
    public float posY;
    public float speedX;
    public int nErros;
    public GameObject player;

    private void Start()
    {
        nErros = 6;
    }

    public void OnClick(string erro)
    {
        PlayerPrefs.SetInt("erros",PlayerPrefs.GetInt("erros")+1);
        DestroyImmediate(GameObject.Find(erro));
        DestroyImmediate(GameObject.Find(erro+"Btn"));
        nErros--;
    }

    public void WinCheck()
    {
        if(nErros == 0)
        {
            Timer.stop = true;
            PlayerPrefs.SetInt("Sustem",PlayerPrefs.GetInt("Sustem") + 2*Mathf.CeilToInt(Timer.time));
            SceneManager.LoadScene("Vitoria");
        }
        
    }

    private void FixedUpdate()
    {
        float hor = Input.GetAxisRaw("Horizontal");
        if (player.transform.localPosition.x > -25 && player.transform.localPosition.x < 25)
        {
            posX += hor * speedX;
        }
        //transform.localPosition = new Vector3(posX, posY, 0);
        transform.position = new Vector3(posX,posY,0);
        WinCheck();
    }
}
