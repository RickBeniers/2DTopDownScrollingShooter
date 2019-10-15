using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    //public int level = 1;
    //public int health = 10;

    public int Time =0;
    public int Kills =0;
    public string userName = "TestName";

    public Text TimerTextField;
    private string TimerText;

    private bool destroyme;
    public GameObject PauseMenuUI;
    public GameObject ShopMenuUI;
    public GameObject PlayButton;
    public GameObject InputField;
    public GameObject InputFieldButton;
    public InputField inputt;

    private void Start()
    {
        TimerText = "" + TimerTextField;
        int.TryParse(TimerText, out Time);

        inputt.onEndEdit.AddListener(delegate { DataHandler(inputt); });

    }
    public void SavePlayer()
    {
        //TimerText = "" + TimerTextField;
        //int.TryParse(TimerText, out Time);
        SaveSystems.SavePlayer(this);
        Debug.Log("position saved");
        
    }
    public void LoadPlayer()
    {
        PlayerData data = SaveSystems.LoadPlayer();

        Time = data.Time;
        Kills = data.Kills;
        userName = data.userName;

        Debug.Log("data loaded" + " Time : " + Time + ", Kills : " + Kills + ", username : " + userName);

    }
    public void PlayerSelfDestruct(bool destroySelf)
    {
        if (destroySelf == true)
        {
            gameObject.GetComponentInChildren<SpriteRenderer>().enabled = false;
            //Destroy(gameObject);
            PauseMenuUI.GetComponent<PauseMenu>().Pause();
            PlayButton.SetActive(false);
            ShopMenuUI.SetActive(false);
            InputField.SetActive(true);
            InputFieldButton.SetActive(true);
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "EnemyShipTag")
        {
            destroyme = true;
            Debug.Log("We are hit!");
            //Destroy(gameObject);
            PlayerSelfDestruct(destroyme);
        }
    }
    public void DataHandler(InputField inputstring)
    {
        //Debug.Log(inputstring.text);
        userName = inputstring.text;
        SavePlayer();
        SceneManager.LoadScene("HighscoreScene");
    }
}
