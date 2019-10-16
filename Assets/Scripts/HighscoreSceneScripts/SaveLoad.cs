using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class SaveLoad : MonoBehaviour
{
    public static List<Game> savedGames = new List<Game>();
    //public List<Game> savedGames = new List<Game>();

    public void Save()
    {
        savedGames.Add(Game.current);
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/savedGames.gd");
        bf.Serialize(file, savedGames);
        Debug.Log("Saved " + Application.persistentDataPath + "/savedGames.gd");
        file.Close();
    }
    public void Load()
    {
        if (File.Exists(Application.persistentDataPath + "/savedGames.gd"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/savedGames.gd", FileMode.Open);
            savedGames = (List<Game>)bf.Deserialize(file);
            Debug.Log("Loaded List " + savedGames);
            file.Close();
        }
        else
        {
            Debug.Log("Loading Failed");
        }
    }
}
