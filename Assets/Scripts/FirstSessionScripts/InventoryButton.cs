using UnityEngine;
using UnityEngine.UI;

public class InventoryButton : MonoBehaviour
{
    [SerializeField]
    private Image myIcon;
    public void SetIcon(Sprite mySprite)
    {
        myIcon.sprite = mySprite;
    }
    private void Update()
    {
        ////this.GetComponent<Text>().enabled = false;
        //if (GetComponentInChildren<Text>().enabled == false)
        //{
        //    FindObjectOfType<Canvas>().GetComponentInChildren<InventoryControll>().TextActive = false;
        //}
        //if (GetComponentInChildren<Text>().enabled == true)
        //{
        //    FindObjectOfType<Canvas>().GetComponentInChildren<InventoryControll>().TextActive = true;
        //}
    }
    public void SelectTextActive()
    {
        if (GetComponentInChildren<Text>().enabled == false && FindObjectOfType<Canvas>().GetComponentInChildren<InventoryControll>().TextActive == false)
        {
            GetComponentInChildren<Text>().enabled = true;
            FindObjectOfType<Canvas>().GetComponentInChildren<InventoryControll>().TextActive = true;
        }
        else if(GetComponentInChildren<Text>().enabled == true && FindObjectOfType<Canvas>().GetComponentInChildren<InventoryControll>().TextActive == true)
        {
            GetComponentInChildren<Text>().enabled = false;
            FindObjectOfType<Canvas>().GetComponentInChildren<InventoryControll>().TextActive = false;
        }
    }

}
