
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogueController : MonoBehaviour
{
    public GameObject dBox;

    public Text dText;
    public Text infoText;
    public Text optionText;

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

        if (dialogueActive && Input.GetKeyDown(KeyCode.F1))
        {
            infoText.gameObject.SetActive(true);
            optionText.gameObject.SetActive(false);
        }
        if (dialogueActive && Input.GetKeyDown(KeyCode.F2))
        {
            //dBox.SetActive(false);
            dialogueActive = false;
            dText.gameObject.SetActive(false);
            infoText.gameObject.SetActive(false);
            optionText.gameObject.GetComponents<Text>();
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
        Debug.Log(DialogueInfo);
        infoText.text = DialogueInfo;
        
    }
    
}
