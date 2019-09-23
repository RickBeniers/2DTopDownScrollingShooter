using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PointsController : MonoBehaviour
{
    [SerializeField]
    private int currentXP = 0;
    [SerializeField]
    private int currentGold = 0;

    public Text XPcounter;
    public Text Goldcounter;

    // Start is called before the first frame update
    void Start()
    {
        XPcounter.text = "0";
        Goldcounter.text = "0";
    }

    
    public void GainXP(int XpToGive)
    {
        currentXP += XpToGive;
        XPcounter.text = "" + currentXP;
    }
    public void GainGold(int GoldToGive)
    {
        currentGold += GoldToGive;
        Goldcounter.text = "" + currentGold;
    }
}
