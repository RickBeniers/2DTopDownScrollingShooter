﻿using UnityEngine;
using System.Collections.Generic;

public class QuestController : MonoBehaviour
{
    public QuestObject[] quests;
    public bool[] questsCompleted;
    public DialogueController dm;

    // Start is called before the first frame update
    void Start()
    {
        questsCompleted = new bool[quests.Length];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void showQuestText(string questText)
    {
        //Debug.Log(questText);
        dm.ShowInfoTextBox(questText);
        
    }
}
