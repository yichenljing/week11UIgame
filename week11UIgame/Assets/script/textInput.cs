using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class textInput : MonoBehaviour
{
    public InputField inputfield;
    GameController controller;
    private void Awake()
    {
        controller = GetComponent<GameController>();
        inputfield.onEndEdit.AddListener(AcceptStringInput);
    }
    void AcceptStringInput(string userInput) {

        userInput = userInput.ToLower(); // convert inpout words to lowercase

        controller.LogStringWithReturn(userInput);

        InputComplete();
    }
    void InputComplete() {              // when finish input
        controller.DisplayLoggedText();
        inputfield.ActivateInputField();
        inputfield.text = null; //empty text

    }
  
}
