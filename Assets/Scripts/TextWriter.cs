using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextWriter : MonoBehaviour
{

    private List<TextWriterSingle> textWriterSingleList;

    private static TextWriter instance;

    private void Awake()
    {
        instance = this;
        textWriterSingleList = new List<TextWriterSingle>();
    }

    public static void RemoveWriter_Static(Text uitext)
    {
        instance.RemoveWriter(uitext);
    }

    private void RemoveWriter(Text uitext)
    {
        for (int i=0; i < textWriterSingleList.Count; i++)
        {
            if(textWriterSingleList[i].GetUIText() == uitext)
            {
                textWriterSingleList.RemoveAt(i);
                i--;
            }
        }
    }


    public static TextWriterSingle AddWriter_Static(Text uitext, string texttowrite, float timeperchar, bool invisiblecharacters, bool removewriterbeforeadd)
    {
        if (removewriterbeforeadd)
        {
            instance.RemoveWriter(uitext);
        }
        return instance.AddWriter(uitext, texttowrite, timeperchar, invisiblecharacters);
    }

    public TextWriterSingle AddWriter(Text uitext, string texttowrite, float timeperchar, bool invisiblecharacters)
    {
        TextWriterSingle textWriterSingle = new TextWriterSingle(uitext, texttowrite, timeperchar, invisiblecharacters);
        textWriterSingleList.Add(textWriterSingle);
        return textWriterSingle;
    }

    private void Update()
    {
        for (int i = 0; i < textWriterSingleList.Count; i++)
        {
            bool destroyInstance = textWriterSingleList[i].Update();
            if (destroyInstance)
            {
                textWriterSingleList.RemoveAt(i);
                i--;
            }
        }
    }




    public class TextWriterSingle
    {

        private Text uitext;
        private string texttowrite;
        private int characterIndex;
        private float timeperchar;
        private float timer;
        private bool invisiblecharacters;
        
        public TextWriterSingle(Text uitext, string texttowrite, float timeperchar, bool invisiblecharacters)
        {
            this.uitext = uitext;
            this.texttowrite = texttowrite;
            this.timeperchar = timeperchar;
            this.invisiblecharacters = invisiblecharacters;
            characterIndex = 0;
        }

        public bool Update()
        {
            
            timer -= Time.deltaTime;
            while (timer <= 0f)
            {
                //display next char
                timer += timeperchar;
                characterIndex++;
                string text = texttowrite.Substring(0, characterIndex);
                if (invisiblecharacters)
                {
                    text += "<color=#00000000>" + texttowrite.Substring(characterIndex) + "</color>";
                }
                uitext.text = text;

                if (characterIndex >= texttowrite.Length)
                {
                    //cabou a string
                    uitext = null;
                    return true;
                }
            }
            return false;
            
        }

        public Text GetUIText()
        {
            return uitext;
        }

        public bool isactive()
        {
            return characterIndex < texttowrite.Length;
        }

        public void WriteAllandDestroy()
        {
            uitext.text = texttowrite;
            characterIndex = texttowrite.Length;
            TextWriter.RemoveWriter_Static(uitext);
        }
    }
}
