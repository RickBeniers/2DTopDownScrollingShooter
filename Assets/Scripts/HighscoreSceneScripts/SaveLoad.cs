using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class SaveLoad 
{
    //public static List<Game> savedGames = new List<Game>();
    public ArrayList playerdatas = new ArrayList();

    public void Save()
    {
        playerdatas.Add(Game.current);
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/savedGames.gd");
        bf.Serialize(file, playerdatas);
        Debug.Log("Saved " + Application.persistentDataPath + "/savedGames.gd");
        file.Close();
    }
    public void Load()
    {
        if (File.Exists(Application.persistentDataPath + "/savedGames.gd"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/savedGames.gd", FileMode.Open);
            playerdatas = bf.Deserialize(file) as ArrayList;
            Debug.Log("Loaded List " + playerdatas.GetType() );
            file.Close();
        }
    }
}
