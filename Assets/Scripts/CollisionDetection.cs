﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public GameObject damageBurst;

    //[SerializeField]
    private int damageToGive;

    private GameObject healthScript;
    private GameObject go;

    // Start is called before the first frame update
    void Start()
    {
        healthScript = GameObject.Find("EnemyHealth");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "EnemyShipTag" && gameObject.tag == "PlayerBulletTag")
        {
            GameObject go = Instantiate(damageBurst, transform.position, transform.rotation);
            go.transform.parent = GameObject.Find("EffectCollector").transform;
            //GetComponent<EnemyHealth>().HurtEnemy(damageToGive);
            Debug.Log("Destroy");
            Destroy(gameObject);
            Destroy(go, 10f);
        } 
        if(collision.tag == "playerShipTag" && gameObject.tag == "EnemyBulletTag")
        {
            Debug.Log("we are hit!");
        }
    }
}
