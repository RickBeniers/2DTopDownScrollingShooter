using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAirplaneList : MonoBehaviour
{

    [SerializeField]private GameObject[] PlayerSpriteList;
    public GameObject CurrentPlayerSprite;
    public GameObject DefaultPlayerSprite;
    public GameObject Level1PlayerSprite;
    public GameObject Level2PlayerSprite;

    [SerializeField] private int playerSpriteNumber;

    // Start is called before the first frame update
    void Start()
    {
        PlayerSpriteAssignment(CurrentPlayerSprite);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void PlayerSpriteAssignment(GameObject CurrentSprite)
    {
        switch (playerSpriteNumber)
        {
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
        }
    }
}
