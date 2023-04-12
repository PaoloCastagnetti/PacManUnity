using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost_Movement : MonoBehaviour
{
    [SerializeField]
    private float _unitPerFrame;

    private Vector3 _currentDirection;

    // Start is called before the first frame update
    void Start()
    {
        _currentDirection = Vector3.up;
    }

    void Update()
    {
        transform.position = _currentDirection * _unitPerFrame + transform.position;
    }

    public void changeDirection(Vector3 direction)
    {
        _currentDirection = direction;
    }

    public void changePosition(Vector3 vector3)
    {
        transform.position = vector3;
    }

    public Vector3 getCurrentdirection()
    {
        return _currentDirection;
    }
}
