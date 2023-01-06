using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {

    //Create public variable speed to set player's speed
    public float speed;

    //Public variable jumpspeed to set player's jumpingspeed
    public float jumpspeed;

    private Rigidbody2D rb;

    //Transform to check if player is touching ground
    public Transform groundCheck;

    //Float to set how far player can be from ground to keep onGround as true
    public float groundCheckRadius;

    //LayerMask to set what objects are ground
    public LayerMask whatIsGround;

    //Boolean to set if player is on ground
    private bool onGround;


    // Use this for initialization
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }
	
	void Update ()
    {
        //Check if player is on ground. If on ground: true. If not: false
        onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);

        //Set speed for player
        rb.velocity = new Vector2(speed, rb.velocity.y);

        //Cube jumps if mousebutton pressed and cube is on ground
        if (Input.GetMouseButtonDown(0) && onGround)
        {
            //Maintain x-velocity but add velocity to y-axis
            rb.velocity = new Vector2(rb.velocity.x, jumpspeed);
        }

        if(transform.position.y < -8.0)
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
