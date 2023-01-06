using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour {

    private Rigidbody2D rb;

    //Private float to set the speed of the platforms
    private float speed = 3;

    //Boolean firstTouch to check if player has touched the platform
    private bool firstTouch;

    //Transform to check if player is touching ground
    public Transform playerCheck;

    //Float to set how far player can be from ground to keep onGround as true
    public float groundCheckRadius;

    //LayerMask to set what objects are ground
    public LayerMask whatIsGround;

    //Boolean to set if player is on ground
    private bool onGround;

    // Use this for initialization
    void Start ()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();

        //firstTouch is false until player touches ground first time
        firstTouch = false;

    }
	
	// Update is called once per frame
	void Update ()
    {
        //Check if player is on ground. If on ground: true. If not: false
        onGround = Physics2D.OverlapCircle(playerCheck.position, groundCheckRadius, whatIsGround);
        if (onGround && firstTouch == false)
        {
            //If touching ground, set firstTouch to true
            firstTouch = true;
        }
        //If player has touched ground the first time, it is free to move forward
        else if (firstTouch == true)
        {
            //Set speed for player
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }

        if(playerCheck.position.x < -5.0)
        {
            rb.velocity = new Vector2(0, 0);
        }
    }
}
