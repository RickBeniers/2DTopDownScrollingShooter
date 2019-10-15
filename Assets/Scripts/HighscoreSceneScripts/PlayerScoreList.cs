using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScoreList : MonoBehaviour
{
    public GameObject PlayerScoreEntry;
    public GameObject Hsm;

    // Start is called before the first frame update
    void Start()
    {
        Canvas.ForceUpdateCanvases();
        Hsm = GameObject.Find("HighscoreController");
        //Hsm.GetComponent<HighscoreManager>();

        
    }

    // Update is called once per frame
    void Update()
    {
        while(this.transform.childCount > 0)
        {
            Transform c = this.transform.GetChild(0);
            c.SetParent(null);
            Destroy(c.gameObject);
        }

        string[] names = Hsm.GetComponent<HighscoreManager>().GetPlayerNames("Kills");

        foreach (string name in names)
        {
            GameObject go = (GameObject)Instantiate(PlayerScoreEntry);
            go.transform.SetParent(this.transform);
            go.transform.Find("Usernames").GetComponent<Text>().text = name;
            go.transform.Find("Time").GetComponent<Text>().text = Hsm.GetComponent<HighscoreManager>().GetScore(name, "Time").ToString() + " s";
            go.transform.Find("Kills").GetComponent<Text>().text = Hsm.GetComponent<HighscoreManager>().GetScore(name, "Kills").ToString();
        }
    }
}
