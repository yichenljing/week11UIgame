using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class changeDisplayText : MonoBehaviour
{
   
    public Text Displaytext;

    public string replaceText; // write the replace text there
   

    //Gets the name submitted by the player and updates the text
    public void replace()
    {
        print("wrong answer");
      Displaytext.text = replaceText;  //replace replaceWithName with the first name the player submitted in welcome text


    }
}

