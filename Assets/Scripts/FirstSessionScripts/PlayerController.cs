using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    private void Start()
    {
        TimerText = "" + TimerTextField;
        int.TryParse(TimerText, out Time);
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

        //level = data.level;
        //health = data.health;
        //Vector3 position;
        //position.x = data.position[0];
        //position.y = data.position[1];
        //position.z = data.position[2];
        //transform.position = position;
    }
    public void PlayerSelfDestruct(bool destroySelf)
    {
        if (destroySelf == true)
        {
            Destroy(gameObject);
            PauseMenuUI.GetComponent<PauseMenu>().Pause();
            PlayButton.SetActive(false);
            ShopMenuUI.SetActive(false);
            InputField.SetActive(true);
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
}
