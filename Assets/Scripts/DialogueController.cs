
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogueController : MonoBehaviour
{
    public GameObject dBox;

    public Text dText;
    public Text infoText;
    public Text optionText;
    public Text EventText;
    public Text EventTextB;

    public bool dialogueActive;
    public bool QuestActive;

    //public string info;
    public string[] DialogueLines;
    public int currentLine;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (dialogueActive == false) 
        {
            dText.GetComponent<Text>().enabled = false;
            infoText.GetComponent<Text>().enabled = false;
            optionText.GetComponent<Text>().enabled = false;
        }
        if (dialogueActive && Input.GetKeyDown(KeyCode.F1))
        {
            infoText.GetComponent<Text>().enabled = true;
            optionText.GetComponent<Text>().enabled = false;
        }
        if (dialogueActive && Input.GetKeyDown(KeyCode.F2))
        {
            //dBox.SetActive(false);
            dialogueActive = false;
            dText.GetComponent<Text>().enabled = false;
            infoText.GetComponent<Text>().enabled = false;
            optionText.GetComponent<Text>().enabled = false;
        }

    }
    public void ShowBox(string Dialogue)
    {
        dialogueActive = true;
        dBox.SetActive(true);
        dText.text = Dialogue;
    }
    public void ShowInfoTextBox(string DialogueInfo)
    {
        //Debug.Log(DialogueInfo);
        infoText.text = DialogueInfo;
        
    }
    public void EventTextManager(int Gold, int XP, int Key, int Key2)
    {
        EventText.enabled = true;
        EventTextB.enabled = true;
        EventText.CrossFadeAlpha(1.0f, 0.01f, false);
        EventTextB.CrossFadeAlpha(1.0f, 0.01f, false);

        //key will decide wich type of Text is shown
        if (Key == 1)
        {
            if (Key2 == 1)
            {
                //if XP & Gold is added 
                EventText.text = " + " + XP + " XP & " + Gold + " Gold";
                EventText.CrossFadeAlpha(0.0f, 4.0f, false);
                EventTextB.enabled = false;
            }
            else if (Key2 == 2)
            {
                EventTextB.text = " + " + XP + " XP & " + Gold + " Gold";
                EventTextB.CrossFadeAlpha(0.0f, 4.0f, false);
                EventText.enabled = false;
            }
            
        }
        if (Key == 2)
        {
            //if only Gold is added
            EventText.text = " + " + Gold + " Gold";
            EventText.CrossFadeAlpha(0.0f, 4.0f, false);
        }
        if (Key == 3)
        {
            //if only Xp is added
            EventText.text = " + " + XP + " XP";
            EventText.CrossFadeAlpha(0.0f, 4.0f, false);
        }
        //Activate the event text
        //EventText.enabled = true;
        //fade out the text
        //EventText.CrossFadeAlpha(0.0f, 5.0f, false);
    }
    
}
