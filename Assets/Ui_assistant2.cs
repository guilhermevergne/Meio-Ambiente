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
                "Clique no computador para realizar o seu cadastro!",
                "Oh oh, infelizmente você não pode adentrar o SENAI Cimatec com as vestimentas escolhidas. Por favor, volte e escolha novamente.",
                "Parabéns, você escolheu vestimentas adequadas para adentrar o SENAI Cimatec. Sua entrada está liberada !!!!",
                "Mas atenção, você está recebendo 1.000 sustens para serem utilizadas nas próximas missões. \nPortanto, cuidado com as suas escolhas, pois elas impactam na sua pontuação final!!!!",
                    
                };
                if (i == 0)
                {
                    string message = messageArray[i];
                    textWriterSingle = TextWriter.AddWriter_Static(messageText, message, .05f, true, true);
                    i = 1;
                }
                else if (i == 1 && PlayerPrefs.GetString("charGen") == "Vestimenta inadequada!")
                {
                    string message = messageArray[i];
                    textWriterSingle = TextWriter.AddWriter_Static(messageText, message, .05f, true, true);
                }
                else if (i == 1 && PlayerPrefs.GetString("charGen") == "Created")
                {
                    string message = messageArray[i+1];
                    textWriterSingle = TextWriter.AddWriter_Static(messageText, message, .05f, true, true);
                    i = 2;
                }
                else if (i == 2)
                {
                    string message = messageArray[i+1];
                    textWriterSingle = TextWriter.AddWriter_Static(messageText, message, .05f, true, true);
                    i = 3;
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
         "sua aventura aqui, primeiro é necessario que se cadastre no sistema para ter seu acesso liberado.", .02f, true, true);
        }
       
    }
}
