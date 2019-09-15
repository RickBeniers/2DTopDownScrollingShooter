using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    private Rigidbody2D rb;
    private BoxCollider2D bc;

    [SerializeField]
    private Vector2 moveSpeed;
    [SerializeField]
    private bool Detected;

    public BoxCollider2D bcd;

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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Debug.Log("Player Detected");
            Detected = true;
        }
    }
    private void OnTriggerEnter2D(Collider collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Debug.Log("Boom");
        }
    }
}
