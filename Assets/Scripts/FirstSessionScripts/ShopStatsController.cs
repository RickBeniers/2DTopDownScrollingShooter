using UnityEngine.UI;
using UnityEngine;

public class ShopStatsController : MonoBehaviour
{
    public Text ItemName;
    public Text ItemType;
    public Text ItemWeaponmain;
    public Text ItemWeaponSec;
    public Text ItemAmmo;
    public Text ItemEngine;
    public Text ItemFuelgage;

    public void SetDialoqueItem01()
    {
        ItemName.text = "Hannover CL.II, Gray";
        ItemType.text = "Fighter";
        ItemWeaponmain.text = "1x 7.92mm Spandau LMG";
        ItemWeaponSec.text = "none";
        ItemAmmo.text = "250(1 belt)";
        ItemEngine.text = "Argus As.III, 180hp";
        ItemFuelgage.text = "360 kg";
    }
    public void SetDialoqueItem02()
    {
        ItemName.text = "Hannover CL.II, Blue";
        ItemType.text = "Fighter";
        ItemWeaponmain.text = "1x 7.92mm Spandau LMG";
        ItemWeaponSec.text = "none";
        ItemAmmo.text = "250(1 belt)";
        ItemEngine.text = "Argus As.III, 180hp";
        ItemFuelgage.text = "360 kg";
    }
    public void SetDialoqueItem03()
    {
        ItemName.text = "Hannover CL.II, Green";
        ItemType.text = "Fighter";
        ItemWeaponmain.text = "1x 7.92mm Spandau LMG";
        ItemWeaponSec.text = "none";
        ItemAmmo.text = "250(1 belt)";
        ItemEngine.text = "Argus As.III, 180hp";
        ItemFuelgage.text = "360 kg";
    }
}
