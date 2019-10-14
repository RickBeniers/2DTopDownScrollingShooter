using UnityEngine; //to use this script within unity
using System.IO; //to open/close and change files on the system.
using System.Runtime.Serialization.Formatters.Binary; //to give acces to binary formater.

public static class SaveSystems {

    public static void SavePlayer(PlayerController player)
    {
        //instantiate the binaryFormatter which we will use to encrypt the saved data.
        BinaryFormatter formatter = new BinaryFormatter();

        //to create a file path in the system + a folder to save the data inside off.
        string path = Application.persistentDataPath + "/player.savedData";

        //filestream is use to read and write from a particular file and create the file we want to store/save data in.
        FileStream stream = new FileStream(path, FileMode.Create);

        //write the data into the file and close the connection when done.
        PlayerData data = new PlayerData(player);
        Debug.Log("data saved " + data.ToString());

        formatter.Serialize(stream, data);
        stream.Close();
    }
    public static PlayerData LoadPlayer()
    {
        //go to the location of the file.
        string path = Application.persistentDataPath + "/player.savedData";

        //check if a file exists.
        if (File.Exists(path))
        {
            //open the binary formatter.
            BinaryFormatter formatter = new BinaryFormatter();

            //open the savefile
            FileStream stream = new FileStream(path, FileMode.Open);
            Debug.Log("file path = " + path);
            //read the data.
            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            Debug.Log("data loaded " + data.ToString());
            stream.Close();
            return data;

        }
        else
        {
            Debug.Log("save file not found in" + path);
            return null;
        }
    }
}
