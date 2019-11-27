using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject NameInputField;
    public GameObject NameButton;

    public void TurnOnNameButton() {
        NameButton.SetActive(true);



    }
}
