using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused = true;
    public GameObject StartMenu;
    public GameObject StartMenuShop;
    public GameObject Playbutton;
    public int B;

    // Start is called before the first frame update
    void Start()
    {
        Pause();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPaused)
            {
                Resume();
                StartMenuShop.SetActive(false);
                Playbutton.SetActive(false);
                FindObjectOfType<PlayerAirplaneList>().PlayerSpriteAssignment(B);
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        StartMenu.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
        
    }
    public void Pause()
    {
        StartMenu.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }
   
}
