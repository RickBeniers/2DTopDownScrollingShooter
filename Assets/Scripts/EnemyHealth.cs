using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    internal object enemyHealthCounter;
    [SerializeField]
    private float MaxHealth;
    [SerializeField]
    private float CurrentHealth;
    public Image Healthbar;

    [SerializeField]
    private float startHealth;
    

    [SerializeField]
    private int XpToGive;
    [SerializeField]
    private int GoldTogive;
    private GameObject playermanager;
    private GameObject Questmanager;
    [SerializeField]
    private bool enemyKilled;


    private void Start()
    {
        CurrentHealth = MaxHealth;
        MaxHealth = startHealth;

        playermanager = GameObject.Find("PlayerManager");
    }
    public void Update()
    {
        if(CurrentHealth <= 0)
        {
            enemyKilled = true;
            Destroy(gameObject);
            //instantiate explosion effect
            playermanager.GetComponent<PointsController>().GainGold(GoldTogive);
            playermanager.GetComponent<PointsController>().GainXP(XpToGive);
            playermanager.GetComponent<PointsController>().GainKills();
        }
            
    }

    public void HurtEnemy(int damageToGive)
    {
        CurrentHealth -= damageToGive;
        Healthbar.fillAmount = CurrentHealth / startHealth;
    }
    public void SetMaxHealth()
    {
        CurrentHealth = MaxHealth;
    }
}
