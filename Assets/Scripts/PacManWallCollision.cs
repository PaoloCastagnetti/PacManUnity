using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacManWallCollision : CollisionHandler
{
    public MC_Movement MC_Controller;
    protected override void internalOnCollisionEnter2D(Collision2D collision)
    {
        base.internalOnCollisionEnter2D(collision);
        MC_Controller.changeDirection(Vector3.zero);
        Debug.LogFormat("Direction changed to ZERO");
    }
}
