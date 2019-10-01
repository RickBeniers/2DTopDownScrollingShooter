﻿using System.Collections;
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
    private int Distance;
    [SerializeField]
    private Vector2 StartDistance;
    [SerializeField]
    private Vector2 CurrentDistance;

    public Text XPcounter;
    public Text Goldcounter;
    public Text InfoCounter;

    private GameObject Questmanager;

    // Start is called before the first frame update
    void Start()
    {
        XPcounter.text = "0";
        Goldcounter.text = "0";
        Questmanager = GameObject.Find("QuestManager");
        StartDistance = new Vector2();
    }
    private void Update()
    {
        CurrentDistance = new Vector2();
        CurrentDistance -= StartDistance;
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
        //CurrentDistance -= StartDistance;
    }
}
