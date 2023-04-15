using UnityEngine;

public class TriggerHandler : MonoBehaviour {
    private void OnTriggerEnter2D() {
        internalOnTriggerEnter2D();
    }

    protected virtual void internalOnTriggerEnter2D() { }
}
