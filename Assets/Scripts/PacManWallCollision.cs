using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacManWallCollision : CollisionHandler
{
    public MC_movement MC_Controller;
    protected override void internalOnCollisionEnter2D()
    {
        base.internalOnCollisionEnter2D();
        MC_Controller.changeDirection(Vector3.zero);
        Debug.LogFormat("Direction changed to ZERO");
    }
}
