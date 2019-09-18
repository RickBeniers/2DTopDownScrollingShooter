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
    private float XpToGive;
    [SerializeField]
    private float GoldTogive;

    private void Start()
    {
        CurrentHealth = MaxHealth;
        MaxHealth = startHealth;
    }
    private void Update()
    {
        if(CurrentHealth <= 0)
        {
            Destroy(gameObject);
            //instantiate explosion effect
            XpToGive += 10;
            GetComponent<PointsController>().GainGold(XpToGive);
            GoldTogive += 100;
            GetComponent<PointsController>().GainXP(GoldTogive);
            
        }
    }

    public void HurtEnemy(int damageToGive)
    {
        CurrentHealth -= damageToGive;
        Healthbar.fillAmount = CurrentHealth / 100f;
    }
    public void SetMaxHealth()
    {
        CurrentHealth = MaxHealth;
    }
}
