using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField]
    private bool bulletInRange = false;
    private BoxCollider2D bcd;

    [SerializeField]
    private int damageToGive;
    

    // Start is called before the first frame update
    void Start()
    {
        bcd = GetComponent<BoxCollider2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {

        if ((col.tag == "playerShipTag") || (col.tag == "PlayerBulletTag"))
        {
            //Debug.Log("Boom");
            bulletInRange = true;
            GetComponentInParent<EnemyHealth>().HurtEnemy(damageToGive);
        }
    }

}
