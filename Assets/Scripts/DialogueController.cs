
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogueController : MonoBehaviour
{
    public GameObject dBox;
    public Text dText;
    public bool dialogueActive;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(dialogueActive)
        {
            
        }
    }
    public void ShowBox(string Dialogue)
    {
        dialogueActive = true;
    }
}
