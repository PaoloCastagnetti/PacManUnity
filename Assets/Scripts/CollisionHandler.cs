using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        internalOnCollisionEnter2D();
    }
    protected virtual void internalOnCollisionEnter2D() { }
}
