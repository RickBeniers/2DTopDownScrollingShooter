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
            Destroy(gameObject);
            //instantiate explosion effect
            playermanager.GetComponent<PointsController>().GainGold(GoldTogive);
            playermanager.GetComponent<PointsController>().GainXP(XpToGive);
            
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
