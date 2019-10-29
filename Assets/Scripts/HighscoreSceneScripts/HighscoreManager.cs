﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class HighscoreManager : MonoBehaviour
{
    Dictionary<string, Dictionary<string, int> > PlayerScore;

    private int Time;
    private int Kills;
    private int Kills2;
    private int Kills3;
    private int Kills4;
    private int Kills5;
    private int Kills6;
    private string userName;

    public GameObject SL;
    //public ArrayList savedDatas = new ArrayList();
    public List<string> loadedstats = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        SetScore("Rick", "Time", 500);
        SetScore("Rick", "Kills", 9);

        SetScore("BOB", "Time", 1500);
        SetScore("BOB", "Kills", 50);
        SetScore("BBB", "Deaths", 3);
        SetScore("CCC", "Time", 6);

        //GetComponent<PlayerController>().LoadPlayer();
        //SaveSystems.LoadPlayer();
        //savedData.Add(data.savedData);

        loadedstats = SaveSystems.LoadPlayer();

        int.TryParse(loadedstats[0], out Kills);
        int.TryParse(loadedstats[1], out Time);
                     userName = loadedstats[2];
        //int.TryParse(loadedstats[2], out Kills);
        //int.TryParse(loadedstats[3], out Kills3);
        //int.TryParse(loadedstats[4], out Kills4);
        //int.TryParse(loadedstats[5], out Kills5);

        //Kills = (int)data[0];
        //Time = (int)data[1];
        //userName = "" + data[2];

        SetScore(userName, "Time", Time);
        SetScore(userName, "Kills", Kills);

        Debug.Log("data loaded" + " Time : " + Time + ", Kills : " + Kills + ", username : " + userName);
        Debug.Log("List Counted objects = " + loadedstats.Count);
        Debug.Log("List capacity = " + loadedstats.Capacity);
    }
    void Init()
    {
        if (PlayerScore != null)
        {
            return;
        }
        else
        {
            PlayerScore = new Dictionary<string, Dictionary<string, int>>();
        }
    }
    public int GetScore(string userName, string scoreType)
    {
        Init();
        if (PlayerScore.ContainsKey(userName) == false)
        {
            return 0;
        }
        if(PlayerScore[userName].ContainsKey(scoreType) == false)
        {
            return 0;
        }
        return PlayerScore[userName][scoreType];
    }
    public void SetScore(string userName, string scoreType, int value)
    {
        Init();
        if (PlayerScore.ContainsKey(userName) == false)
        {
            PlayerScore[userName] = new Dictionary<string, int>();
        }
        PlayerScore[userName][scoreType] = value;
    }
    public void ChangeScore(string userName, string scoreType, int amount)
    {
        Init();
        int currScore = GetScore(userName, scoreType);
        SetScore(userName, scoreType, currScore + amount);
    }
    public string[] GetPlayerNames(string sortingScoreType)
    {
        Init();
        return PlayerScore.Keys.OrderByDescending( n => GetScore(n, sortingScoreType) ).ToArray();
    }

    
}
