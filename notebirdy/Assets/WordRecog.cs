using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordRecog : MonoBehaviour
{
    List<string> letters = new List<string>();
    string myword
    string[] mywords = new string ["BEANS","HICKEN", "TOMATO"];

    // Start is called before the first frame update
    void Start()
    {

        myword = mywords(0,mywords.Length -1);

    }

    // Update is called once per frame
    void Update()
    {


    }

    void OnGUI()
    {
        if (Event.current.type == EventType.KeyDown && Event.current.keyCode != KeyCode.None)
        {
            Debug.Log("current event detected" + Event.current);
            letters.Add(Event.current.keyCode.ToString());

            for (int i = 0; i <= letters.Count; i++)
            {

                if (letters[i] == myword.Substring(1, 1))
                {
                    Debug.Log("yay" + letters[1] + "==" + myword.Substring(i, 1));

                    if (letters.Count == myword.Length)
                    {
                        Debug.Log("you typed" + myword + "Yay u are cool");
                        TextAlignment.color = green;
                    }
                else
                {
                    Debug.Log("boo" + letters[1] + "!=" + myword.Substring(i, 1));
                    letters.Clear();

                        if (letters.Count != myword.Length)
                        
                            Debug.Log("you didn't" + myword + "BOO!!!");
                        TextAlign, text.text = myword word
                        }
                }
                //foreach (string letter in letters) { Debug.Log(letter); } // printing out 
            }
        }
    }
}

