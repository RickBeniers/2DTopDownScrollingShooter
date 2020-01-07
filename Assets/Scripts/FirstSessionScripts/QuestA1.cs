using UnityEngine;
using UnityEngine.UI;

public class QuestA1 : MonoBehaviour
{
    public QuestObject questa1;
    public string dialogue;
    private DialogueController dc;

    public Text descriptionText;
    //public Text infoText;
    public Text optionText;
    private GameObject Questmanager;
    private bool QuestStarted;

    private void Start()
    {
        //questa1 = FindObjectOfType<QuestObject>();
        dc = FindObjectOfType<DialogueController>();
        Questmanager = GameObject.Find("QuestManager");
    }
    public void Update()
    {
        
    }
    public void FinishQuest(bool finished)
    {
        Questmanager.GetComponentInChildren<QuestObject>().endQuest();
        Debug.Log("finished Quest");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "playerShipTag")
        {
            optionText.GetComponent<Text>().enabled = true;
            descriptionText.text= "Text";
            dc.ShowBox(dialogue);
            QuestStarted = true;
            questa1.startQuest(QuestStarted);
            Destroy(gameObject);
        }
    }
}
