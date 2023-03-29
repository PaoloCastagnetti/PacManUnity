using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsCollision : CollisionHandler
{
    protected override void internalOnCollisionEnter2D()
    {
        base.internalOnCollisionEnter2D();
        Destroy(gameObject);
        Debug.LogFormat("Point eated!");
    }
}
