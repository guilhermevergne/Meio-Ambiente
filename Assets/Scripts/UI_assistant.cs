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
                    "Oh oh, infelizmente voc� n�o pode adentrar o SENAI Cimatec com as vestimentas escolhidas. Por favor, volte e escolha novamente.",
					"�Maravilhaaa! Voc� cumpriu com o desafio  por isso tem acesso liberado! Todos que passam por aqui recebem esta garrafa, guarde com cuidado, voc� vai precisar dela. Tenha uma �tima visita!�!",
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
            if (PlayerPrefs.GetInt("Jogo da Pia") == 0)
            {
                textWriterSingle = TextWriter.AddWriter_Static(messageText, "Este � o refeit�rio, aqui voc� far� uma refei��o. " +
                    "Mas antes de se servir, primeiro lave as suas m�os.", .02f, true, true);
                transform.Find("DialogueText").GetComponent<Button_UI>().ClickFunc = () =>
                {
                    textWriterSingle = TextWriter.AddWriter_Static(messageText, " ", .02f, true, true);
                    transform.Find("DialogueBox").GetComponent<Image>().color = new Color(1f, 1f, 1f, 0f);
                    /*if (i == 0)
                    {
                        textWriterSingle = TextWriter.AddWriter_Static(messageText, "Este � o refeit�rio, aqui voc� far� uma refei��o. " +
                        "Mas antes de se servir, primeiro lave as suas m�os.", .02f, true, true);
                        i = 1;
                    }
                    else if (i == 1)
                    {
                        textWriterSingle = TextWriter.AddWriter_Static(messageText, " ", .02f, true, true);
                        transform.Find("DialogueBox").GetComponent<Image>().color = new Color(1f, 1f, 1f, 0f);
                    }*/
                };
            }
            else if(PlayerPrefs.GetInt("Jogo da Comida") == 0)
            {
                textWriterSingle = TextWriter.AddWriter_Static(messageText, "Hum� que cheiro bom, está na hora do almo�o." +
                    "\nAproveite e monte a sua refei��o. mas n�o esque�a de higienizar as m�os antes!", .02f, true, true);
            }
            else if (PlayerPrefs.GetInt("Jogo do Descarte") == 0)
            {
                textWriterSingle = TextWriter.AddWriter_Static(messageText, "Agora que voc� j� comeu, descarte corretamente" +
                    " os res�duos em cada cesto.", .02f, true, true);
                transform.Find("DialogueText").GetComponent<Button_UI>().ClickFunc = () =>
                {
                    if (i == 0)
                    {
                        textWriterSingle = TextWriter.AddWriter_Static(messageText, "Lembrando que: Verde (Vidro), Azul (papel), " +
                            "Vermelho (pl�stico), Amarelo (Metal), e Marrom(Org�nico).", .02f, true, true);
                        i = 1;
                    }
                    else if (i == 1)
                    {
                        textWriterSingle = TextWriter.AddWriter_Static(messageText, " ", .02f, true, true);
                        transform.Find("DialogueBox").GetComponent<Image>().color = new Color(1f, 1f, 1f, 0f);
                    }
                };
            }

        }
        else if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            messageText = transform.Find("DialogueText").GetComponent<Text>();

            textWriterSingle = TextWriter.AddWriter_Static(messageText, "Voc� precisa lavar suas m�os. " +
                "Escolha a torneia mais adequada.", .02f, true, true);

            GameObject.Find("Btn0").GetComponent<Button_UI>().ClickFunc = () =>
            {
                if (textWriterSingle != null && textWriterSingle.isactive())
                {
                    textWriterSingle.WriteAllandDestroy();
                }
                else if (i == 0)
                {
                    textWriterSingle = TextWriter.AddWriter_Static(messageText, "Parab�ns, voc� escolheu a pia mais adequada. " +
						" Muito bem! � importante lavar as m�os controlando a quantidade de �gua gasta, a sua escolha economiza at� 70% mais �gua", .02f, true, true);
                }
                else if (i == 1)
                {
                    textWriterSingle = TextWriter.AddWriter_Static(messageText, "Algumas vezes as escolhas tradicionais s�o melhores. " +
                        "O secador mais adequado � o papel toalha, al�m de diminuir a prolifera��o de bactérias em até 24%, ele n�o emite" +
                        " carbono.\nAgora que j� secou as m�os, volte ao refeitério e fa�a sua refei��o", .02f, true, true);
                    i = 2;
                }

            };

            GameObject.Find("Btn1").GetComponent<Button_UI>().ClickFunc = () =>
            {
                if (textWriterSingle != null && textWriterSingle.isactive())
                {
                    textWriterSingle.WriteAllandDestroy();
                }
                else if (i == 0)
                {
                    textWriterSingle = TextWriter.AddWriter_Static(messageText, "A torneira mais adequada é a com sensor, ela gera uma economia" +
                        " de até 70% no uso de água.\n Agora que j� lavou as mãos, seque-as da melhor forma para o meio ambiente", .02f, true, true);
                    i = 1;
                }
                else if (i == 1)
                {
                    textWriterSingle = TextWriter.AddWriter_Static(messageText, "Algumas vezes as escolhas tradicionais s�o melhores. " +
                        "O secador mais adequado é o papel toalha, al�m de diminuir a proliferação de bactérias em até 24%, ele não emite" +
                        " carbono. Agora que já secou as mãos, volte ao refeitório e faça sua refeição", .02f, true, true);
                    i = 2;
                }
            };

            GameObject.Find("Btn2").GetComponent<Button_UI>().ClickFunc = () =>
            {
                if (textWriterSingle != null && textWriterSingle.isactive())
                {
                    textWriterSingle.WriteAllandDestroy();
                }
                else if (i == 0)
                {
                    textWriterSingle = TextWriter.AddWriter_Static(messageText, "A torneira mais adequada � a com sensor, ela gera uma economia" +
                        " de at� 70% no uso de �gua. Agora que j� lavou as m�os, seque-as da melhor forma para o meio ambiente", .02f, true, true);
                    i = 1;
                }
                else if (i == 1)
                {
                    textWriterSingle = TextWriter.AddWriter_Static(messageText, "Parab�ns, voc� escolheu o secador mais adequado. " +
                        "Agora que j� secou as m�os, volte ao refeit�rio e fa�a sua refei��o", .02f, true, true);
                    i = 2;
                }
            };

            GameObject.Find("DialogueText").GetComponent<Button_UI>().ClickFunc = () =>
            {
                if (i == 2)
                {
                    SceneManager.LoadScene("Refeitorio");
                }
            };
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
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            if (charcreate)
            {
                textWriterSingle = TextWriter.AddWriter_Static(messageText, "Para prosseguir, entre no elevador e se dirija ao refeit�rio. Boa sorte!", .05f, true, true);
            }
            else
            {
                textWriterSingle = TextWriter.AddWriter_Static(messageText, "Ol�, seja bem-vindo ao SENAI CIMATEC! Para iniciarmos a " +
				"visita! � indispens�vel o uso correto das roupas aqui na nossa institui��o." +
                " Por isso o seu objetivo � escolher a roupa adequada para ter acesso livre!!!\n", .02f, true, true);
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
                textWriterSingle = TextWriter.AddWriter_Static(messageText, "Escolha a torneira mais ecologica para lavar as suas m�os!", .02f, true, true);
            }
        }


    }
}