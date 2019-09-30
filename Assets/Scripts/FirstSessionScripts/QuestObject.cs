using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestObject : MonoBehaviour
{
    [SerializeField]
    private int questNumber;
    [SerializeField]
    private QuestController QC;

    private string startText;
    private string endText;

    public Text dText;
    public Text infoTexts;
    public Text optionText;

    private int XpToGive;
    private int GoldTogive;
    private int Key;
    private int KeySecond;

    private GameObject playermanager;
    private GameObject dialogueController;
    [SerializeField]
    public int Counter;
    public Text infoText;
    public GameObject questobject;

    public bool QS;

    private bool QuestEnded = false;

    public void Start()
    {
        questobject = GameObject.Find("QuestTest");
        playermanager = GameObject.Find("PlayerManager");
        dialogueController = GameObject.Find("DialoqueManager");
    }
    public void startQuest(bool QuestStarted)
    {
        QC.showQuestText(startText);
        if (QuestStarted == true)
        {
            QS = true;
        }
        
    }
    public void endQuest()
    {
        QC.showQuestText(endText);
        QC.questsCompleted[questNumber] = true;
        //gameObject.SetActive(false);
        dText.GetComponent<Text>().enabled = false;
        infoText.GetComponent<Text>().enabled = false;
        optionText.GetComponent<Text>().enabled = false;
    }
    public void KillCount(int amount)
    {
        Counter = amount;
        if (QuestEnded == false)
        {
            infoText.text = "" + Counter + "/10";
        }
        if (Counter == 10 && QuestEnded == false && QS == true)
        {
            GoldTogive = 1000;
            XpToGive = 5000;
            Key = 2;
            //Debug.Log("Completed Mission!");
            playermanager.GetComponent<PointsController>().GainGold(GoldTogive);
            playermanager.GetComponent<PointsController>().GainXP(XpToGive);
            dialogueController.GetComponent<DialogueController>().EventBTextManager(GoldTogive,XpToGive,Key);
            endQuest();
            QuestEnded = true;
        }
    }
}
