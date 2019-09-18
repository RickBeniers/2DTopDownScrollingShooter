using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public GameObject damageBurst;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "EnemyShipTag")
        {
            GameObject go = Instantiate(damageBurst, transform.position, transform.rotation);
            go.transform.parent = GameObject.Find("EffectCollector").transform;
            Destroy(gameObject);
        }
    }
}
