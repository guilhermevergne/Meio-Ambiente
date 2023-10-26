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
					"Maravilha! Você cumpriu com o desafio  por isso tem o acesso liberado! Clique no elevador e tenha uma ótima visita!!!",
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
                transform.Find("DialogueText").GetComponent<Button_UI>().ClickFunc = () =>
                {
                    textWriterSingle = TextWriter.AddWriter_Static(messageText, " ", .02f, true, true);
                    transform.Find("DialogueBox").GetComponent<Image>().color = new Color(1f, 1f, 1f, 0f);
                    /*if (i == 0)
                    {
                        textWriterSingle = TextWriter.AddWriter_Static(messageText, "Este é o refeitório, aqui você fará uma refeição. " +
                        "Mas antes de se servir, primeiro lave as suas mãos.", .02f, true, true);
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
                textWriterSingle = TextWriter.AddWriter_Static(messageText, "Hummm! Que cheiro bom, está na hora do almoço." +
                    "\nAgora que já lavou as mãos, aproveite e monte a sua refeição!", .02f, true, true);
                transform.Find("DialogueText").GetComponent<Button_UI>().ClickFunc = () =>
                {
                    textWriterSingle = TextWriter.AddWriter_Static(messageText, " ", .02f, true, true);
                    transform.Find("DialogueBox").GetComponent<Image>().color = new Color(1f, 1f, 1f, 0f);
                };
            }
            else if (PlayerPrefs.GetInt("Jogo do Descarte") == 0)
            {
                textWriterSingle = TextWriter.AddWriter_Static(messageText, "Agora que você já comeu, descarte corretamente" +
                    " os resíduos em cada cesto.", .02f, true, true);
                transform.Find("DialogueText").GetComponent<Button_UI>().ClickFunc = () =>
                {
                    if (i == 0)
                    {
                        textWriterSingle = TextWriter.AddWriter_Static(messageText, "Lembrando que: Verde (Vidro), Azul (papel), " +
                            "Vermelho (plástico), Amarelo (Metal), e Marrom(Orgânico).", .02f, true, true);
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

            textWriterSingle = TextWriter.AddWriter_Static(messageText, "Você precisa lavar suas mãos. " +
                "Escolha a torneia mais adequada.", .02f, true, true);

            GameObject.Find("Btn0").GetComponent<Button_UI>().ClickFunc = () =>
            {
                if (textWriterSingle != null && textWriterSingle.isactive())
                {
                    textWriterSingle.WriteAllandDestroy();
                }
                else if (i == 0)
                {
                    textWriterSingle = TextWriter.AddWriter_Static(messageText, "Parabéns, você escolheu a pia mais adequada. " +
						" Muito bem! É importante lavar as mãos controlando a quantidade de água gasta, a sua escolha economiza até 70% mais água", .02f, true, true);
                }
                else if (i == 1)
                {
                    textWriterSingle = TextWriter.AddWriter_Static(messageText, "Algumas vezes as escolhas tradicionais são melhores. " +
                        "O secador mais adequado é o papel toalha, além de diminuir a proliferação de bactérias em até 24%, ele não emite" +
                        " carbono.\nAgora que já secou as mãos, volte ao refeitério e faça sua refeição", .02f, true, true);
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
                        " de até 70% no uso de água.\n Agora que já lavou as mãos, seque-as da melhor forma para o meio ambiente", .02f, true, true);
                    i = 1;
                }
                else if (i == 1)
                {
                    textWriterSingle = TextWriter.AddWriter_Static(messageText, "Algumas vezes as escolhas tradicionais são melhores. " +
                        "O secador mais adequado é o papel toalha, além de diminuir a proliferação de bactérias em até 24%, ele não emite" +
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
                    textWriterSingle = TextWriter.AddWriter_Static(messageText, "A torneira mais adequada é a com sensor, ela gera uma economia" +
                        " de até 70% no uso de água. Agora que já lavou as mãos, seque-as da melhor forma para o meio ambiente", .02f, true, true);
                    i = 1;
                }
                else if (i == 1)
                {
                    textWriterSingle = TextWriter.AddWriter_Static(messageText, "Parabéns, você escolheu o secador mais adequado. " +
                        "Agora que já secou as mãos, volte ao refeitório e faça sua refeição", .02f, true, true);
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
				"visita! É indispensável o uso correto das roupas aqui na nossa instituição." +
                " Por isso o seu objetivo é escolher a roupa adequada para ter acesso livre!!!\n", .02f, true, true);
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
                textWriterSingle = TextWriter.AddWriter_Static(messageText, "Escolha a torneira mais ecologica para lavar as suas mãos!", .02f, true, true);
            }
        }


    }
}