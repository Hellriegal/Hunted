using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegPull : MonoBehaviour
{
    public GameObject LegEnd;
    public GameObject LimbOne;
    Transform LimbOneTransform;
    Transform myTransform;
    Vector2 AnchorPoint;
    Rigidbody2D rb2d;
    bool ifMoveLeg = true;
    bool updateMovePosition = true;
    Vector2 moveOneAngle;
    Vector2 moveTwoAngle;
    [SerializeField]
    public bool bodyMove = false;

    void Start()
    {
        LimbOneTransform = LimbOne.GetComponent<Transform>();
        rb2d = LegEnd.GetComponent<Rigidbody2D>();
        myTransform = LegEnd.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        moveLeg();
    }

    

    void moveLeg()
    {
        if (ifMoveLeg == true)
        {
           if (updateMovePosition == true)
            {
                moveOneAngle = new Vector2(myTransform.position.x + 140, myTransform.position.y + 50);
                moveTwoAngle = new Vector2(myTransform.position.x + 250, myTransform.position.y);
                updateMovePosition = false;
            }
            if (Vector2.Distance(LimbOneTransform.position, myTransform.position) < 220)
             {
                rb2d.velocity = new Vector2(rb2d.velocity.x + 1, rb2d.velocity.y);
             }
            else
            {
                ifMoveLeg = false;
                bodyMove = true;
            }
            
        }

    }
}
