using UnityEngine;

public class CollisionHandler : MonoBehaviour {
    private void OnCollisionEnter2D(Collision2D collision) {
        internalOnCollisionEnter2D(collision);
    }
    protected virtual void internalOnCollisionEnter2D(Collision2D collision) { }
}