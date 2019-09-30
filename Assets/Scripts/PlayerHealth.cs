using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField]
    private float MaxHealth;
    [SerializeField]
    private float CurrentHealth;
    [SerializeField]
    private float startHealth;

    public Image Healthbar;
    public Text PlayerHealthText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CurrentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
    public void HurtPlayer(int damageToGive)
    {
        CurrentHealth -= damageToGive;
        Healthbar.fillAmount = CurrentHealth / startHealth;
    }
    public void SetMaxPlayerHealth()
    {
        CurrentHealth = MaxHealth;
    }
}
