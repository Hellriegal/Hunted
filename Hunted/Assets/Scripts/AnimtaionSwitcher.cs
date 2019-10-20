using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimtaionSwitcher : MonoBehaviour
{
    public KeyBoardMovement KBD;
    SpriteRenderer sR;
    Animator anim;
    [SerializeField]
    int aDirection;
    // Start is called before the first frame update
    void Start()
    {
        sR = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        assignDirection();
        switcher();
    }

    void assignDirection()
    {
        aDirection = KBD.direction;
    }

    void switcher()
    {
        switch(aDirection)
        {
            case 0:
                anim.Play("Idle");
                break;
            case 3:
                sR.flipX = true;
                anim.Play("JudasRunCycle");
                break;
            case 4:
                sR.flipX = false;
                anim.Play("JudasRunCycle");
                break;
        }
    }
}
