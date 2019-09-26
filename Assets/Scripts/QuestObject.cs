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
    [SerializeField]
    public int Counter;
    public Text infoText;


    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void startQuest()
    {
        startText = "Enemies destroyed " + Counter + "/10";
        QC.showQuestText(startText);
    }
    public void endQuest()
    {
        QC.showQuestText(endText);
        QC.questsCompleted[questNumber] = true;
        gameObject.SetActive(false);
    }
    public void KillCounter(int KillCount)
    {
        Counter = KillCount;
        infoText.text = "" + Counter + "/10";
    }
}
