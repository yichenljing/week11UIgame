using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class UISubmitName : MonoBehaviour
{
    public Text playerNameText; 
    public Text DisplayText;

    public string welcomeText;
    public string replaceWithName;

    //Gets the name submitted by the player and updates the text
    public void SubmitName(){
        print("SubmitName is: " + playerNameText.text); //print out the submit name

        string[] names = playerNameText.text.Split(' '); //split the name to just get the first name

        DisplayText.text = welcomeText.Replace(replaceWithName, names[0]); //replace replaceWithName with the first name the player submitted in welcome text
    }
}
