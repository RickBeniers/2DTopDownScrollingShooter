using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public int level;
    public int health;
    public float[] position;

    //collect data from the player script
    public PlayerData (PlayerController player)
    {
        //level = player.level;
        //health = player.health;

        position = new float[3];
        position[0] = player.transform.position.x;
        position[1] = player.transform.position.y;
        position[2] = player.transform.position.z;
    }

    public override string ToString()
    {
        return "PlayerData: " + position[0] + ", "+ position[1] + ", " + position[2];
    }
}
