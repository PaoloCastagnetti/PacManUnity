using UnityEngine;

public class MC_Rotation : MonoBehaviour {
    public MC_Movement MC_Controller;
    private Vector3 _currentDirection;


    private void Start() {

    }
    private void Update() {
        _currentDirection = MC_Controller.getCurrentdirection();
        if (_currentDirection == Vector3.up) {
            transform.rotation = Quaternion.Euler(0, 0, 90);
        } else if (_currentDirection == Vector3.down) {
            transform.rotation = Quaternion.Euler(0, 0, 270);
        } else if (_currentDirection == Vector3.left) {
            transform.rotation = Quaternion.Euler(0, 0, 180);
        } else if (_currentDirection == Vector3.right || _currentDirection == Vector3.zero) {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        } else {
            Debug.LogError("ROTAZIONE IMPOSSIBILE");
        }
    }
}
