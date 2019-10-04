using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //public int level = 1;
    //public int health = 10;
    private bool destroyme;
    public GameObject PauseMenuUI;
    public GameObject PlayButton;

    public void SavePlayer()
    {
        SaveSystems.SavePlayer(this);
        Debug.Log("position saved");
        
    }
    public void LoadPlayer()
    {
        PlayerData data = SaveSystems.LoadPlayer();

        //level = data.level;
        //health = data.health;

        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];
        transform.position = position;
        Debug.Log("previous position loaded");
    }
    public void PlayerSelfDestruct(bool destroySelf)
    {
        if (destroySelf == true)
        {
            Destroy(gameObject);
            PauseMenuUI.GetComponent<PauseMenu>().Pause();
            PlayButton.SetActive(false);
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
//dhsjsjsjsjsjsjsjsrhtkykukdghstrdjffykdtjd