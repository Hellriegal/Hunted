using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyMove : MonoBehaviour
{
    public LegPull lP1;

    Rigidbody2D rb2d;
    [SerializeField]
    bool ifMoveBody = false;
    
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        rb2d.freezeRotation = true;
        moveBody();
    }

    void moveBody()
    {
        ifMoveBody = lP1.bodyMove;
        if (ifMoveBody == true)
        {
            rb2d.velocity = new Vector2(60, rb2d.velocity.y);
        }
    }
}
