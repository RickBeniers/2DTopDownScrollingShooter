using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PointsController : MonoBehaviour
{
    [SerializeField]
    private float currentXP =0;
    [SerializeField]
    private float currentGold =0;

    public Text XPcounter;
    public Text Goldcounter;

    // Start is called before the first frame update
    void Start()
    {
        //XPcounter = 
    }

    
    public void GainXP(float XpToGive)
    {
        currentXP += XpToGive;
        
    }
    public void GainGold(float GoldToGive)
    {
        currentGold += GoldToGive;

    }
}
