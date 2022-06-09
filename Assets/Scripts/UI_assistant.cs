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
                {/*
                    string[] messageArray = new string[]{
                };
                    string message = messageArray[i];
                    textWriterSingle = TextWriter.AddWriter_Static(messageText, message, .05f, true, true);*/
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
            if (PlayerPrefs.GetInt("Jogo da Pia") == 0)
            {
                textWriterSingle = TextWriter.AddWriter_Static(messageText, "Este é o refeitório, aqui você fará uma refeição. " +
                    "Mas antes de se servir, primeiro lave as suas mãos.", .02f, true, true);
            }
            else
            {
                textWriterSingle = TextWriter.AddWriter_Static(messageText, "Hum… que cheiro bom, está na hora do almoço." +
                    "\nAproveite e monte a sua refeição.", .02f, true, true);
            }
            
        }
        else if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            messageText = transform.Find("DialogueText").GetComponent<Text>();
            GameObject.Find("Btn0").GetComponent<Button_UI>().ClickFunc = () =>
            {
                if (textWriterSingle != null && textWriterSingle.isactive())
                {
                    textWriterSingle.WriteAllandDestroy();
                }
                else
                {
                    textWriterSingle = TextWriter.AddWriter_Static(messageText, "Parabéns, você escolheu a pia mais adequada. " +
                        "Agora que já lavou as mãos, seque-as da melhor forma para o meio ambiente", .02f, true, true);
                }
            };

            GameObject.Find("Btn1").GetComponent<Button_UI>().ClickFunc = () =>
            {
                if (textWriterSingle != null && textWriterSingle.isactive())
                {
                    textWriterSingle.WriteAllandDestroy();
                }
                else
                {
                    textWriterSingle = TextWriter.AddWriter_Static(messageText, "Infelizmente essa não é a pia correta. " +
                        "Agora que já lavou as mãos, seque-as da melhor forma para o meio ambiente", .02f, true, true);
                }
            };

            GameObject.Find("Btn2").GetComponent<Button_UI>().ClickFunc = () =>
            {
                if (textWriterSingle != null && textWriterSingle.isactive())
                {
                    textWriterSingle.WriteAllandDestroy();
                }
                else
                {
                    textWriterSingle = TextWriter.AddWriter_Static(messageText, "Infelizmente essa não é a pia correta. " +
                        "Agora que já lavou as mãos, seque-as da melhor forma para o meio ambiente", .02f, true, true);
                }
            };
        }


    }

    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            textWriterSingle = TextWriter.AddWriter_Static(messageText, "Ao visitar o Senai CIMATEC, você terá como objetivo resolver os desafios " +
            "de produção mais limpa (P + L) que ocorrerão durante o percurso. Portanto, fique atento às dicas e aos avisos para " +
            "conseguir a maior recompensa de todas, receber a coroa da sustentabilidade!", .02f, true, true);

        }
        if (SceneManager.GetActiveScene().buildIndex == 1)
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
        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            if (textWriterSingle != null && textWriterSingle.isactive())
            {
                textWriterSingle.WriteAllandDestroy();
            }
            else
            {
                textWriterSingle = TextWriter.AddWriter_Static(messageText, "Escolha a pia mais ecologicamente adequada!", .02f, true, true);
            }
        }


    }
}