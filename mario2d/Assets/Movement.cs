using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 10f;
    public Rigidbody2D rb;
    public bool isGrounded = true;
    
    void Start()
    {
        rb  = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal"); 
        rb.velocity = new Vector2(x * speed, rb.velocity.y);


        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            isGrounded = false; 
        }


    }
    void OnTriggerEnter2D(Collider2D other)
    {


        if (other.tag == "Ground")
        {
            isGrounded = true;
        }
    }
}
