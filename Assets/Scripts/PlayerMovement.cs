using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float mapWidth = 5f;

    public Rigidbody2D rb;

    Vector2 movement;

    private void Start()
    {
        //rb.GetComponent<Rigidbody2D>();
        rb.GetComponentInParent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        //detect input

        //when pressing 'A' input = -1 and 'D' input = 1
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }
    void FixedUpdate()
    {
        //create movement based on Input

        //move the rigidbody to new position which = current position + our movement * moveSpeed and * Time.fixedDeltaTime to create constant movespeed.
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

    }
}
