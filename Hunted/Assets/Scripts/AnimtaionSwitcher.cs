using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimtaionSwitcher : MonoBehaviour
{
    Transform myTransform;
    public KeyBoardMovement KBD;
    SpriteRenderer sR;
    Animator anim;
    [SerializeField]
    int aDirection;
    bool updateDirection = true;
    bool direction = true;
    // Start is called before the first frame update
    void Start()
    {
        sR = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        myTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        assignDirection();
        switcher();
        land();
    }

    void updateDirectionTrue()
    {
        updateDirection = true;
    }

    void assignDirection()
    {
        if (KBD.direction == 3)
        {
            direction = false;
        }
        if (KBD.direction == 4)
        {
            direction = true;
        }
        

        if (updateDirection == true)
        {
            aDirection = KBD.direction;
        }
    }

    void aDirectionAnimationDecider()
    {
        aDirection = -3;
    }

    void aDirectionZero()
    {
        aDirection = 0;
    }

    void land()
    {
        LayerMask mask = LayerMask.GetMask("Platform");
        RaycastHit2D hit = Physics2D.Raycast(myTransform.position, Vector2.down, 200, mask);
        RaycastHit2D GroundTouch = Physics2D.Raycast(myTransform.position, Vector2.down, 1, mask);

        if ((aDirection == -3 || aDirection == -1) & hit == true)
        {
            updateDirectionTrue();
        }
        if (GroundTouch == false)
        {
            
            aDirection = -1;
            updateDirection = false;
        }
    }

    void switcher()
    {
        if (direction == false)
        {
            sR.flipX = true;
        }
        else
        {
            sR.flipX = false;
        }
        switch(aDirection)
        {
            case -2:
                anim.Play("Land");
                break;
            case -1:
                anim.Play("Fall");
                break;
            case 0:
                anim.Play("Idle");
                break;
            case 1:
                anim.Play("Jump");
                updateDirection = false;
                break;
            case 3:
                anim.Play("JudasRunCycle");
                break;
            case 4:
                anim.Play("JudasRunCycle");
                break;
        }
    }
}
