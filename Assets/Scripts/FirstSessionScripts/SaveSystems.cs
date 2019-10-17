using UnityEngine;                                                              //to use this script within unity
using System.IO;                                                                //to open/close and change files on the system.
using System.Runtime.Serialization.Formatters.Binary;                           //to give acces to binary formater.
using System;
using System.Collections;

public static class SaveSystems
{
    //public static ArrayList savedData = new ArrayList();
    private const string Save_Separator = "##Save-VALUE##";

    public static void SavePlayer(PlayerController player)
    {

        //BinaryFormatter formatter = new BinaryFormatter();                      //instantiate the binaryFormatter which we will use to encrypt the saved data.
        //string path = Application.persistentDataPath + "/player.savedData";     //to create a file path in the system + a folder to save the data inside off.
        //FileStream stream = new FileStream(path, FileMode.Create);              //filestream is use to read and write from a particular file and create the file we want to store/save data in.
        //PlayerData data = new PlayerData(player);                               //write the data into the file and close the connection when done.
        ////Debug.Log("data saved " + data.ToString());
        //formatter.Serialize(stream, data);
        //stream.Close();
        string saveStringName = "" + player.name;
        string saveStringKills = "" + player.Kills;
        string saveStringTime = "" + player.Time;

        string saveSeparator = "##Save-VALUE##";
        string[] contents = new string[]
        {
            saveStringName,
            saveStringKills,
            saveStringTime,
        };

        string saveString = string.Join(Save_Separator, contents);
        File.WriteAllText(Application.persistentDataPath + "/playerScores.txt", saveString);
        //Debug.Log(Application.persistentDataPath + "/playerScores.txt");
    }
    public static void LoadPlayer()
    {

        string path = Application.persistentDataPath + "/playerScores.txt";     //go to the location of the file.

        if (File.Exists(path))                                                  //check if a file exists.
        {

            //BinaryFormatter formatter = new BinaryFormatter();                  //open the binary formatter.
            //FileStream stream = new FileStream(path, FileMode.Open);            //open the savefile
            //Debug.Log("file path = " + path);
            //PlayerData data = formatter.Deserialize(stream) as PlayerData;      //read the data.
            ////Debug.Log("data loaded " + data.ToString());
            //stream.Close();
            //return data                                                        //return the data

            string saveString = File.ReadAllText(Application.persistentDataPath + "/playerScores.txt");
            string[] contents = saveString.Split(new[] { Save_Separator }, System.StringSplitOptions.None);
            Debug.Log(saveString);
        }
        else
        {
            Debug.Log("save file not found in" + path);
            //return null;
        }
    }
}
