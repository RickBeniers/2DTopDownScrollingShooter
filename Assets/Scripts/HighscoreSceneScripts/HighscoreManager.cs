using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class HighscoreManager : MonoBehaviour
{
    Dictionary<string, Dictionary<string, int> > PlayerScore;

    private int Time;
    private int Kills;
    private string userName;

    // Start is called before the first frame update
    void Start()
    {
        //SetScore("Rick", "Time", 500);
        //SetScore("Rick", "Kills", 9);

        //SetScore("BOB", "Time", 1500);
        //SetScore("BOB", "Kills", 50);
        //SetScore("BBB", "Deaths", 3);
        //SetScore("CCC", "Time", 6);

        PlayerData data = SaveSystems.LoadPlayer();

        Time = data.Time;
        Kills = data.Kills;
        userName = data.userName;

        SetScore(userName, "Time", Time );
        SetScore(userName, "Kills", Kills);

        //Debug.Log("data loaded" + " Time : " + Time + ", Kills : " + Kills + ", username : " + userName);
        //Debug.Log(GetScore(userName, "Kills"));

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
