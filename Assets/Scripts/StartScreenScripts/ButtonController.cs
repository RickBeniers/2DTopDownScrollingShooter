using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    [SerializeField]
    private bool enabled = true;
    public GameObject DeleteButton;

    private void Update()
    {
        if (Input.GetButtonUp("F11") && enabled == true)
        {
            //button is activated
            Debug.Log("button is activated");
            DeleteButton.SetActive(false);
            enabled = false;

        }
        else
        {
            if (Input.GetButtonDown("F11") && enabled == false)
            {
                //button is deactivated
                Debug.Log("button is deactivated");
                DeleteButton.SetActive(true);
                enabled = true;

            }
        }

    }
    public void StartButton()
    {
        SceneManager.LoadScene("FirstSessionScene");
    }
    public void QuitButton()
    {
        Application.Quit();
    }
    public void HighscoreButton()
    {
        SceneManager.LoadScene("HighscoreScene");
    }
    public void StartScreenButton()
    {
        SceneManager.LoadScene("StartScreen");
    }
    public void DeleteData()
    {
        Debug.Log("Data Deleted");
    }
}
