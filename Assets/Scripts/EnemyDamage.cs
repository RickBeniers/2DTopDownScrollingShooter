using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    [SerializeField]
    private bool bulletInRange = false;
    private BoxCollider2D bcd;

    // Start is called before the first frame update
    void Start()
    {
        bcd = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (bcd.gameObject.tag == "Bullet")
        {
            Debug.Log("Boom");
            bulletInRange = true;
        }
    }
}
