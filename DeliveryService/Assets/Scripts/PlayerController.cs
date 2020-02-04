using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(PolygonCollider2D))]

public class PlayerController : MonoBehaviour
{

    public int speed = 5;                //Floating point variable to store the player's movement speed
    private Rigidbody2D rb2d;          //Store a reference to Rigidbody2D component required to use 2D Physics
    public KeyCode moveUp;
    public KeyCode moveDown;
    
    // Start is called before the first frame update
    void Start()
    {
        //Get and store a reference to the Rigidbody2D component so that we can access it.
        rb2d = GetComponent<Rigidbody2D>();
                
    }

    void Update()
    {

        GetComponent<Rigidbody2D>().velocity = transform.forward * speed;

        if (Input.GetKey(moveUp))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
        }
        else if (Input.GetKey(moveDown))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed * -1);
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
    }
}
