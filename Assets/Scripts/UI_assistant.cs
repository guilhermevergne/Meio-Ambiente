using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CodeMonkey.Utils;
using UnityEngine.SceneManagement;


public class UI_assistant : MonoBehaviour
{
    private Text messageText;
    private TextWriter.TextWriterSingle textWriterSingle;
    private int i;
    

    private void Awake()
    {
        messageText = transform.Find("DialogueText").GetComponent<Text>();

        transform.Find("DialogueText").GetComponent<Button_UI>().ClickFunc = () =>
        {
            if(textWriterSingle != null && textWriterSingle.isactive())
            {
                textWriterSingle.WriteAllandDestroy();
            }
            else {
                string[] messageArray = new string[]{
                
                "Cuidado com suas escolhas, todas as suas ações contam para o seu score final!",
                };
                    string message = messageArray[i];
                    textWriterSingle = TextWriter.AddWriter_Static(messageText, message, .05f, true, true);
                    //  i = 1;
                
                /*else if (i == 1)
                {
                    string message = messageArray[i];
                    textWriterSingle = TextWriter.AddWriter_Static(messageText, message, .05f, true, true);
                    i = 0;
                }*/
                
                
            }
            
        };
    }

    private void Start()
    {
        textWriterSingle = TextWriter.AddWriter_Static(messageText, "Ao visitar o Senai CIMATEC, você terá como seu objetivo resolver os desafios " +
        "que ocorrerão durante o percurso, fique atento às dicas e aos avisos para " + "conseguir a maior honra de todas, receber a coroa de mais sustentável!", .02f, true, true);
    }
}
