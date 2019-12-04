using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject NameInputField;
    public GameObject NameButton;
    public GameObject Submit;
    public GameObject findTreature;
    public GameObject GOhOME;


    public void TurnOnNameButton() {
        NameButton.SetActive(true);
        Submit.SetActive(false);
        findTreature.SetActive(true);
        GOhOME.SetActive(true);

    }
}
