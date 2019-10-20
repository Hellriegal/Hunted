using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBoardMovement : MonoBehaviour
{
    private Rigidbody2D rb2d;

    [SerializeField]
    int speed = 50;
    int Direction = 0;
    public int direction
    { get { return Direction; } }

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        movement();
    }

    void movement()
    {
        if (Input.GetKey("a"))
        {
            rb2d.velocity = new Vector2(-speed, rb2d.velocity.y);
            Direction = 3;
        }
        else if (Input.GetKey("d"))
        {
            rb2d.velocity = new Vector2(speed, rb2d.velocity.y);
            Direction = 4;
        }
        else
        {
            //rb2d.velocity = new Vector2(rb2d.velocity.x, rb2d.velocity.y);
            Direction = 0;
        }
    }
}
