using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour {

    public float speed = 3.0f;
    public float jump = 5.0f;
    public bool jumped = false;
	// Use this for initialization
	void Start ()
    {

    }
	
	// Update is called once per frame
	void Update ()
    {
        float x = gameObject.transform.position.x;

        if (x-1 > -11.30)
        {
            if (Input.GetKey("a"))
            {
                transform.Translate(Vector2.left * speed * Time.deltaTime);
            }
        }
        if (x + 1 < 11.32)
        {
            if (Input.GetKey("d"))
            {
                transform.Translate(Vector2.right * speed * Time.deltaTime);
            }
        }

        //Welp we can jump forever now sorry, have to understand what constitutes collision and how to check whether the collision is with the bottom of the player

        if (Input.GetKeyDown("w") && jumped == false)
        {
            jumped = true;
            GetComponent<Rigidbody2D>().velocity = (Vector2.up * 7);
        }

        if (Input.GetKeyUp("w"))
        {
            jumped = false;
        }
    }
}
