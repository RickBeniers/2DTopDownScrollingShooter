using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAirplaneList : MonoBehaviour
{

    [SerializeField]
    private List<Sprite> PlayerSpriteList;
    public Sprite CurrentPlayerSprite;

    [SerializeField]
    public int playerSpriteNumber;
    public int placeholder;

    // Start is called before the first frame update
    void Start()
    {
        PlayerSpriteAssignment(playerSpriteNumber);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayerSpriteAssignment(int CurrentSprite)
    {
        switch (CurrentSprite)
        {
            case 1:
                CurrentPlayerSprite = PlayerSpriteList[0];
                placeholder = 1;
                break;
            case 2:
                CurrentPlayerSprite = PlayerSpriteList[1];
                placeholder = 2;
                break;
            case 3:
                CurrentPlayerSprite = PlayerSpriteList[2];
                placeholder = 3;
                break;
        }
    }
}
