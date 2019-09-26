using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestObject : MonoBehaviour
{
    [SerializeField]
    private int questNumber;
    [SerializeField]
    private QuestController QC;

    public string startText;
    public string endText;

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
        QC.showQuestText(startText);
    }
    public void endQuest()
    {
        QC.showQuestText(endText);
        QC.questsCompleted[questNumber] = true;
        gameObject.SetActive(false);
    }
}
