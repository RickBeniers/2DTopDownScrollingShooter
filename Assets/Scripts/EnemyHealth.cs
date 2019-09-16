using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    internal object enemyHealthCounter;
    [SerializeField]
    private int MaxHealth;
    [SerializeField]
    private int CurrentHealth;

    private void Start()
    {
        CurrentHealth = MaxHealth;
    }
    private void Update()
    {
        if(CurrentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void HurtEnemy(int damageToGive)
    {
        CurrentHealth -= damageToGive;
    }
    public void SetMaxHealth()
    {
        CurrentHealth = MaxHealth;
    }
}
