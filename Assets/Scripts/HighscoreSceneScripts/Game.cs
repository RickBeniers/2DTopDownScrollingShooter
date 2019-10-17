using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Game 
{
    System.Collections.ArrayList savedData = new System.Collections.ArrayList();

    public Game(PlayerController player)
    {
        savedData.Add(player.Kills);
        savedData.Add(player.Time);
        savedData.Add(player.name);
    }

}
