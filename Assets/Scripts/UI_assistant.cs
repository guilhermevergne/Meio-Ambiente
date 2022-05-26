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
    private int i = 0;

    public static bool charcreate;

    public GameObject display;

    private void Awake()
    {
        

        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            messageText = transform.Find("DialogueText").GetComponent<Text>();

            transform.Find("DialogueText").GetComponent<Button_UI>().ClickFunc = () =>
            {
                if (textWriterSingle != null && textWriterSingle.isactive())
                {
                    textWriterSingle.WriteAllandDestroy();
                }
                else
                {
                    string[] messageArray = new string[]{

                };
                    string message = messageArray[i];
                    textWriterSingle = TextWriter.AddWriter_Static(messageText, message, .05f, true, true);
                }

            };
        }
        else if (SceneManager.GetActiveScene().buildIndex == 1)
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
                    "Oh oh, infelizmente voc� n�o pode adentrar o SENAI Cimatec com as vestimentas escolhidas. Por favor, volte e escolha novamente.",
                    "Parab�ns, voc� escolheu vestimentas adequadas para adentrar o SENAI Cimatec. Sua entrada est� liberada !!!!",
                    "Mas aten��o, voc� est� recebendo 1.000 sustens para serem utilizadas nas pr�ximas miss�es. \nPortanto, cuidado com as suas escolhas, pois elas impactam na sua pontua��o final!!!!",
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
                        string message = messageArray[i + 1];
                        textWriterSingle = TextWriter.AddWriter_Static(messageText, message, .05f, true, true);
                        i = 2;
                    }
                    else if (i == 2)
                    {
                        string message = messageArray[i + 1];
                        textWriterSingle = TextWriter.AddWriter_Static(messageText, message, .05f, true, true);
                        i = 3;
                    }

                }

            };
        }
        else if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            messageText = transform.Find("DialogueText").GetComponent<Text>();

            textWriterSingle = TextWriter.AddWriter_Static(messageText, "Est� com fome? espero que esteja, bem vindo(a) ao refeitorio! Aqui vo�� sera desafiado e " +
                "recebera Sustens com base na sua performance nesses desafios. Ande por ai e descubra onde eles se encontram, Boa sorte!", .02f, true, true);

            transform.Find("DialogueText").GetComponent<Button_UI>().ClickFunc = () =>
            {
                if (i == 1)
                {
                    display = GameObject.FindGameObjectWithTag("TextDisplay");
                    display.SetActive(!display.activeSelf);
                }

                if (textWriterSingle != null && textWriterSingle.isactive())
                {
                    textWriterSingle.WriteAllandDestroy();

                }
                else
                {
                    string[] messageArray = new string[]{

                };
                    string message = messageArray[i];
                    textWriterSingle = TextWriter.AddWriter_Static(messageText, message, .05f, true, true);

                }
                i++;
            };
        }
        else if(SceneManager.GetActiveScene().buildIndex == 3)
        {
            if (textWriterSingle != null && textWriterSingle.isactive())
            {
                textWriterSingle.WriteAllandDestroy();
            }
            else
            {
                string[] messageArray = new string[]{
                    "Clique no computador para realizar o seu cadastro!",
                    "Oh oh, infelizmente voc� n�o pode adentrar o SENAI Cimatec com as vestimentas escolhidas. Por favor, volte e escolha novamente.",
                    "Parab�ns, voc� escolheu vestimentas adequadas para adentrar o SENAI Cimatec. Sua entrada est� liberada !!!!",
                    "Mas aten��o, voc� est� recebendo 1.000 sustens para serem utilizadas nas pr�ximas miss�es. \nPortanto, cuidado com as suas escolhas, pois elas impactam na sua pontua��o final!!!!",
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
                    string message = messageArray[i + 1];
                    textWriterSingle = TextWriter.AddWriter_Static(messageText, message, .05f, true, true);
                    i = 2;
                }
                else if (i == 2)
                {
                    string message = messageArray[i + 1];
                    textWriterSingle = TextWriter.AddWriter_Static(messageText, message, .05f, true, true);
                    i = 3;
                }

            }
        }


    }

    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            textWriterSingle = TextWriter.AddWriter_Static(messageText, "Ao visitar o Senai CIMATEC, voc� ter� como objetivo resolver os desafios " +
            "de produ��o mais limpa (P + L) que ocorrer�o durante o percurso. Portanto, fique atento �s dicas e aos avisos para " +
            "conseguir a maior recompensa de todas, receber a coroa da sustentabilidade!", .02f, true, true);

        }
        else if(SceneManager.GetActiveScene().buildIndex == 1)
        {
            if (charcreate)
            {
                textWriterSingle = TextWriter.AddWriter_Static(messageText, "Para prosseguir, entre no elevador e se dirija ao refeit�rio. Boa sorte!", .05f, true, true);
            }
            else
            {
                textWriterSingle = TextWriter.AddWriter_Static(messageText, "Ol�, seja bem-vindo ao SENAI CIMATEC! Para iniciarmos a " +
                "sua aventura aqui, primeiro � necessario que se cadastre no sistema para ter seu acesso liberado.", .02f, true, true);
            }
        }
        

    }
}
