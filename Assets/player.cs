using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

    //Declaring movement variables
    float moveSpeed=3.0f;
    float jumpHeight=15.0f;

    //grounded variables
    bool grounded = true;

    //physics 2D components
    Rigidbody2D rb2D;

	// Use this for initialization
	void Start () {
        rb2D = GetComponent<Rigidbody2D>();
	}

    private void Update()
    {
        //Controlling horizontal movement 
        float move = Input.GetAxis("Horizontal");
        rb2D.velocity = new Vector2(move * moveSpeed, rb2D.velocity.y);

        //Controlling Jump
        if (Input.GetKeyDown(KeyCode.Space) && grounded==true)
        {  
                rb2D.velocity = new Vector2(rb2D.velocity.x, jumpHeight);        
        }
        grounded = false;

    }

    private void OnCollisionStay2D()
    {
        grounded = true;
    }

}
