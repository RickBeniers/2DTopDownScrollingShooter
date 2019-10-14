using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PointsController : MonoBehaviour
{
    [SerializeField]
    private int currentXP = 0;
    [SerializeField]
    private int currentGold = 0;
    //[SerializeField]
    public int Kills = 0;
    [SerializeField]
    private int QuestKills;
    [SerializeField]
    private int TimePast;
    [SerializeField]
    private float TimeStart;
    private int timeing;

    public Text TimerText;
   
    public Text XPcounter;
    public Text Goldcounter;
    public Text InfoCounter;

    private GameObject Questmanager;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        XPcounter.text = "0";
        Goldcounter.text = "0";
 
        Questmanager = GameObject.Find("QuestManager");
        player = GameObject.Find("Player");
    }
    private void Update()
    {
        TimeStart += Time.deltaTime;
        TimerText.text = TimeStart.ToString("F2");
        int timeing = (int)TimeStart;
        player.GetComponent<PlayerController>().Time = timeing;
        //Debug.Log(player.GetComponent<PlayerController>().Time);
    }
    public void GainXP(int XpToGive)
    {
        currentXP += XpToGive;
        XPcounter.text = "" + currentXP;
    }
    public void GainGold(int GoldToGive)
    {
        currentGold += GoldToGive;
        Goldcounter.text = "" + currentGold;
    }
    public void GainKills()
    {
        Kills++;
        player.GetComponent<PlayerController>().Kills = Kills;
        if (Questmanager.GetComponentInChildren<QuestObject>().QS == true )
        {
            QuestKills++;
            InfoCounter.text = "" + QuestKills + "/10";
            Questmanager.GetComponentInChildren<QuestObject>().KillCount(QuestKills);
        }
        
    }
    public void CalcDistance()
    {
        
    }
}
