using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    private Rigidbody2D rb;
    private BoxCollider2D bc;

    [SerializeField]
    private Vector2 moveSpeed;

    public BoxCollider2D bcd;
    [SerializeField]
    public int damageToGive;

    public GameObject Canvas;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        bc = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(0, -0.604f);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "PlayerBulletTag")
        {
            Debug.Log("enemy hit");
            //Destroy(gameObject);
            Canvas.SetActive(true);

            GetComponent<EnemyHealth>().HurtEnemy(damageToGive);
            
        }
    }
    

}
