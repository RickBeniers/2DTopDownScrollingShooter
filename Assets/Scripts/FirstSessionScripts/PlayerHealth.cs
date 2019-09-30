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
    [SerializeField]
    private bool destroy;

    private GameObject playerHealthController;

    // Start is called before the first frame update
    void Start()
    {
        playerHealthController = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (CurrentHealth <= 0)
        {
            destroy = true;
            playerHealthController.GetComponent<PlayerController>().PlayerSelfDestruct(destroy);
        }
    }
    public void HurtPlayer(int playerDamageToGive)
    {
        CurrentHealth -= playerDamageToGive;
        Healthbar.fillAmount = CurrentHealth / startHealth;
        PlayerHealthText.text = "Player Health :" + CurrentHealth;
    }
    public void SetMaxPlayerHealth()
    {
        CurrentHealth = MaxHealth;
    }
}
