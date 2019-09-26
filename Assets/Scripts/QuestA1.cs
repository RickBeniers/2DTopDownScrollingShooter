using UnityEngine;

public class QuestA1 : MonoBehaviour
{
    public QuestObject questa1;
    public string dialogue;
    private DialogueController dc;

    private void Start()
    {
        //questa1 = FindObjectOfType<QuestObject>();
        dc = FindObjectOfType<DialogueController>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "playerShipTag")
        {
            dc.ShowBox(dialogue);
            questa1.startQuest();
            Destroy(gameObject);
        }
    }
}
