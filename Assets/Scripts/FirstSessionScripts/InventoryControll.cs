using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryControll : MonoBehaviour
{
    public List<Playeritem> playerInventory;

    [SerializeField]
    private GameObject ButtonTemplate;
    [SerializeField]
    private GridLayoutGroup gridGroup;
    [SerializeField]
    private Sprite[] iconSprites;
    [SerializeField] private int PlayerPlanesAmount;
    public bool TextActive;
    [SerializeField]
    public bool GrayHannoverSelected;
    [SerializeField]
    public bool BlueHannoverSelected;
    [SerializeField]
    public bool GreenHannoverSelected;

    private void Start()
    {
        //PlayerPlanesAmount = 3;
        playerInventory = new List<Playeritem>();
        
        for(int i = 1; i<=PlayerPlanesAmount; i++)
        {
            Playeritem newItem = new Playeritem();
            newItem.iconSprite = iconSprites[Random.Range(0, iconSprites.Length)];

            playerInventory.Add(newItem);
        }
        //GenInventory();
    }
    void GenInventory()
    {
        if (playerInventory.Count < PlayerPlanesAmount)
        {
            gridGroup.constraintCount = playerInventory.Count;
        }
        else
        {
            gridGroup.constraintCount = 10;
        }
        foreach (Playeritem newItem in playerInventory)
        {
            GameObject newButton = Instantiate(ButtonTemplate) as GameObject;
            newButton.SetActive(true);

            newButton.GetComponent<InventoryButton>().SetIcon(newItem.iconSprite);
            newButton.transform.SetParent(ButtonTemplate.transform.parent, false);
            newButton.GetComponentInChildren<Text>().enabled = false;
        }
    }
    public class Playeritem
    {
        public Sprite iconSprite;
    }
   
}
