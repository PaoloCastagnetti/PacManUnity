using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MC_movement : MonoBehaviour
{
    [SerializeField]
    private float _unitPerFrame;

    private Vector3 _currentDirection;

    // Start is called before the first frame update
    void Start()
    {
        _currentDirection = Vector3.zero;
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
}
