using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "textAdventure/Room")] // allow to create instance asset

public class Room : ScriptableObject   // not attached to gameobjs, create assets store or execute data
{
    
    [TextArea] //desplay bigger text box
    public string description;       //description of the room
    public string roomName;
    public Exit[] exits;

}
