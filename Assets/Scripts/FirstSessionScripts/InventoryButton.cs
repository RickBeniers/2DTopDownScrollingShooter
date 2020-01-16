using UnityEngine;
using UnityEngine.UI;

public class InventoryButton : MonoBehaviour
{
    [SerializeField]
    private Image myIcon;
    public bool bought;
    private int ItemSelection;
    public int SpriteNumber;

    public Text ItemName;
    public Text ItemType;
    public Text ItemWeaponmain;
    public Text ItemWeaponSec;
    public Text ItemAmmo;
    public Text ItemEngine;
    public Text ItemFuelgage;

    public void SetIcon(Sprite mySprite)
    {
        myIcon.sprite = mySprite;
    }
    public void SelectTextActive()
    {
        //if (GetComponentInChildren<Text>().enabled == false && FindObjectOfType<Canvas>().GetComponentInChildren<InventoryControll>().TextActive == false)
        //{
        //    GetComponentInChildren<Text>().enabled = true;
        //    FindObjectOfType<Canvas>().GetComponentInChildren<InventoryControll>().TextActive = true;
        //    bought = true;
        //    //Selected
        //}
        //else if(GetComponentInChildren<Text>().enabled == true && FindObjectOfType<Canvas>().GetComponentInChildren<InventoryControll>().TextActive == true)
        //{
        //    GetComponentInChildren<Text>().enabled = false;
        //    FindObjectOfType<Canvas>().GetComponentInChildren<InventoryControll>().TextActive = false;
        //    bought = false;
        //    //DeSelected
        //}
    }
    public void SelectGrayHannover()
    {
        ItemName.text = "Name : Hannover(G)";
        ItemType.text = "Type : Fighter";
        ItemWeaponmain.text = "Main : 1x 7.92mm Spandau";
        ItemWeaponSec.text = "Sec : none";
        ItemAmmo.text = "Ammo : 250(1 belt)";
        ItemEngine.text = "Engine : 180hp";
        ItemFuelgage.text = "Max Fuel : 360 L";

        GameObject.Find("TextBoolG").GetComponent<Text>().enabled = true;
        GameObject.Find("TextBoolB").GetComponent<Text>().enabled = false;
        GameObject.Find("TextBoolGr").GetComponent<Text>().enabled = false;
        FindObjectOfType<Canvas>().GetComponentInChildren<InventoryControll>().GrayHannoverSelected = true;
        FindObjectOfType<Canvas>().GetComponentInChildren<InventoryControll>().BlueHannoverSelected = false;
        FindObjectOfType<Canvas>().GetComponentInChildren<InventoryControll>().GreenHannoverSelected = false;
        GameObject.Find("PlayerManager").GetComponent<PlayerAirplaneList>().playerSpriteNumber = 1;
      
    }
    public void SelectBlueHannover()
    {
        ItemName.text = "Name : Hannover(B)";
        ItemType.text = "Type : Fighter";
        ItemWeaponmain.text = "Main : 1x 7.92mm Spandau";
        ItemWeaponSec.text = "Sec : none";
        ItemAmmo.text = "Ammo : 250(1 belt)";
        ItemEngine.text = "Engine : 180hp";
        ItemFuelgage.text = "Max Fuel : 360 L";

        GameObject.Find("TextBoolG").GetComponent<Text>().enabled = false;
        GameObject.Find("TextBoolB").GetComponent<Text>().enabled = true;
        GameObject.Find("TextBoolGr").GetComponent<Text>().enabled = false;
        FindObjectOfType<Canvas>().GetComponentInChildren<InventoryControll>().GrayHannoverSelected = false;
        FindObjectOfType<Canvas>().GetComponentInChildren<InventoryControll>().BlueHannoverSelected = true;
        FindObjectOfType<Canvas>().GetComponentInChildren<InventoryControll>().GreenHannoverSelected = false;
        GameObject.Find("PlayerManager").GetComponent<PlayerAirplaneList>().playerSpriteNumber = 2;
        
    }
    public void SelectGreenHannover()
    {
        ItemName.text = "Name : Hannover(Gr)";
        ItemType.text = "Type : Fighter";
        ItemWeaponmain.text = "Main : 1x 7.92mm Spandau";
        ItemWeaponSec.text = "Sec : none";
        ItemAmmo.text = "Ammo : 250(1 belt)";
        ItemEngine.text = "Engine : 180hp";
        ItemFuelgage.text = "Max Fuel : 360 L";

        GameObject.Find("TextBoolG").GetComponent<Text>().enabled = false;
        GameObject.Find("TextBoolB").GetComponent<Text>().enabled = false;
        GameObject.Find("TextBoolGr").GetComponent<Text>().enabled = true;
        FindObjectOfType<Canvas>().GetComponentInChildren<InventoryControll>().GrayHannoverSelected = false;
        FindObjectOfType<Canvas>().GetComponentInChildren<InventoryControll>().BlueHannoverSelected = false;
        FindObjectOfType<Canvas>().GetComponentInChildren<InventoryControll>().GreenHannoverSelected = true;
        GameObject.Find("PlayerManager").GetComponent<PlayerAirplaneList>().playerSpriteNumber = 3;
        
    }
}
