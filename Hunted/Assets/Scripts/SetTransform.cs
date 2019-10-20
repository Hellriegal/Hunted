using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTransform : MonoBehaviour
{
    public GameObject toFollow;
    public GameObject follower;

    Transform followerTransform;
    Transform toFollowTransform;

    void Start()
    {
        followerTransform = follower.transform;
        toFollowTransform = toFollow.transform;
    }

    // Update is called once per frame
    void Update()
    {
        followerTransform.position = new Vector2(toFollowTransform.position.x, toFollowTransform.position.y);
    }
}
