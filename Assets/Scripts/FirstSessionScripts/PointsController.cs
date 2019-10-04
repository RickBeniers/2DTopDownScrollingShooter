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

    public Text TimerText;
   
    public Text XPcounter;
    public Text Goldcounter;
    public Text InfoCounter;

    private GameObject Questmanager;

    // Start is called before the first frame update
    void Start()
    {
        //djkykykdthsrsryrtdjygklfykdtsrtsysrdujdgcjfulfudrydujyhkygjdrdjfhlufjsrjdtjfyklfyli;olh,fyhtdryduyfjshdjfykyr
        XPcounter.text = "0";
        Goldcounter.text = "0";
        TimerText.text = TimeStart.ToString("F2");
        Questmanager = GameObject.Find("QuestManager");
        
    }
    private void Update()
    {
        TimeStart += Time.deltaTime;
        TimerText.text = TimeStart.ToString("F2");
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
