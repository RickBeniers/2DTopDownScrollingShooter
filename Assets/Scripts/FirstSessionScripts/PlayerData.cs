using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public ArrayList savedData = new ArrayList();

    //collect data from the player script
    public PlayerData (PlayerController player)
    {
        savedData.Add(player.Kills.ToString());
        savedData.Add(player.Time.ToString());
        savedData.Add(player.name);

        Debug.Log("Kills : " + player.Kills);
        Debug.Log("Time : " + player.Time);
        Debug.Log("name : " + player.name);
    }

    public override string ToString()
    {
        return "PlayerData: ";//+ position[0] + ", "+ position[1] + ", " + position[2];
    }
}
