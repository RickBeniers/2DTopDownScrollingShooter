using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    
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
}
