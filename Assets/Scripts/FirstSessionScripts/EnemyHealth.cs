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
    private int Key;
    private int secondKey;

    private GameObject playermanager;
    private GameObject Questmanager;
    private GameObject dialogueController;
    [SerializeField]
    private bool enemyKilled;


    private void Start()
    {
        CurrentHealth = MaxHealth;
        MaxHealth = startHealth;

        playermanager = GameObject.Find("PlayerManager");
        dialogueController = GameObject.Find("DialoqueManager");
    }
    public void Update()
    {
        if(CurrentHealth <= 0)
        {
            Key = 1;
            enemyKilled = true;
            Destroy(gameObject);
            //instantiate explosion effect
            playermanager.GetComponent<PointsController>().GainGold(GoldTogive);
            playermanager.GetComponent<PointsController>().GainXP(XpToGive);
            playermanager.GetComponent<PointsController>().GainKills();
            dialogueController.GetComponent<DialogueController>().EventTextManager(GoldTogive,XpToGive,Key);
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
