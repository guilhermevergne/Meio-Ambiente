using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CodeMonkey.Utils;
using UnityEngine.SceneManagement;


public class Ui_assistant2 : MonoBehaviour
{
    private Text messageText;
    private TextWriter.TextWriterSingle textWriterSingle;
    private int i;

    public static bool charcreate;



    private void Awake()
    {
        messageText = transform.Find("message").Find("MessageText").GetComponent<Text>();

        transform.Find("message").Find("MessageText").GetComponent<Button_UI>().ClickFunc = () =>
        {
            if (textWriterSingle != null && textWriterSingle.isactive())
            {
                textWriterSingle.WriteAllandDestroy();
            }
            else
            {
                string[] messageArray = new string[]{
                /*"Cuidado com suas escolhas, todas as suas ações contam para o seu score final!"*/"Place Holder",
                "Clique no computador para criar seu cadastro!",
                "Oh oh, infelizmente você não pode adentrar o SENAI Cimatec com as vestimentas escolhidas. Por favor, volte e escolha novamente.",
                "Parabéns, você escolheu vestimentas adequadas para adentrar o SENAI Cimatec.",
                    
                };
                if (i == 0)
                {
                    string message = messageArray[i];
                    textWriterSingle = TextWriter.AddWriter_Static(messageText, message, .05f, true, true);
                    i = 1;
                }
                else if (i == 1)
                {
                    string message = messageArray[i];
                    textWriterSingle = TextWriter.AddWriter_Static(messageText, message, .05f, true, true);
                    i = 2;
                }
                else if (i == 2 && PlayerPrefs.GetString("charGen") == "Vestimenta inadequada!")
                {
                    Debug.Log(i);
                    string message = messageArray[i];
                    textWriterSingle = TextWriter.AddWriter_Static(messageText, message, .05f, true, true);
                }
                else if (i == 2 && PlayerPrefs.GetString("charGen") == "Created")
                {
                    i = 3;
                    string message = messageArray[i];
                    textWriterSingle = TextWriter.AddWriter_Static(messageText, message, .05f, true, true);
                }

            }

        };
    }

    private void Start()
    {
        if (charcreate)
        {
            textWriterSingle = TextWriter.AddWriter_Static(messageText, "Para prosseguir, entre no elevador e se dirija ao refeitório. Boa sorte!", .05f, true, true);
        }
        else
        {
            textWriterSingle = TextWriter.AddWriter_Static(messageText, "Olá, seja bem-vindo ao SENAI CIMATEC! Para iniciarmos a " +
         "sua aventura aqui, é necessario que se cadastre e crie um crachá para ter o seu acesso liberado.", .02f, true, true);
        }
       
    }
}
