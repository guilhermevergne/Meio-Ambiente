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
                if (charcreate)
                {
                    
                }
                else
                    {
                        string[] messageArray = new string[]{
                    "Cuidado com suas escolhas, todas as suas ações contam para o seu score final!",
                    "Clique no computador para criar seu crachá!",
                    
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
         "sua visita ao local, é necessario que se cadastre e crie um crachá para ter o seu acesso liberado.", .02f, true, true);
        }
       
    }
}
