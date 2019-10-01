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
}
