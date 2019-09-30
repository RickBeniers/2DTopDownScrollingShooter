using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public GameObject damageBurst;

    //[SerializeField]
    private int damageToGive;

    //private GameObject healthScript;
    private GameObject go;
    private GameObject playerHealthObject;

    // Start is called before the first frame update
    void Start()
    {
        //healthScript = GameObject.Find("EnemyHealth");
        playerHealthObject = GameObject.Find("PlayerManager");
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
            Destroy(gameObject);
            Destroy(go, 10f);
        } 
        if(collision.tag == "playerShipTag" && gameObject.tag == "EnemyBulletTag")
        {
            //Debug.Log("we are hit!");
            damageToGive = 1;
            playerHealthObject.GetComponent<PlayerHealth>().HurtPlayer(damageToGive);
            GameObject go2 = Instantiate(damageBurst, transform.TransformPoint(0,0,-5), transform.rotation);
            go2.transform.parent = GameObject.Find("EffectCollector").transform;
            Destroy(gameObject);
            Destroy(go2, 10f);
        }
    }
}

