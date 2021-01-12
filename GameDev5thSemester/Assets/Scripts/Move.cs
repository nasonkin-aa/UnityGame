using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float Speed;
    public Vector2 Direction;
    public GameObject WatchTarget;
    float XVector;

    [System.Obsolete]
    void FixedUpdate()
    {
        RandomX();
    }

    [System.Obsolete]
    void RandomX()
    {
        XVector = RandomX.RandomRange(-8, 8f);
        Direction.x = XVector;
        Direction.y = WatchTarget.transform.position.y;
        transform.Translate(Speed * Direction, Space.World);
    }
}