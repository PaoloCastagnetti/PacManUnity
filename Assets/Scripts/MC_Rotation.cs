using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MC_Rotation : MonoBehaviour
{
    public MC_Movement MC_Controller;
    private Vector3 _currentDirection;
    private int _currentOrientation;
    private int _nextOrientation;

    private void Start()
    {
        _currentOrientation = 0;
        _nextOrientation = 0;
    }
    private void Update()
    {
        _currentDirection = MC_Controller.getCurrentdirection();

        if(_currentDirection == Vector3.up)
        {
            if(_currentOrientation == 0)
            {
                _nextOrientation = 90;
            }
            else if(_currentOrientation == 180) 
            {
                _nextOrientation = -90;
            }
            else if (_currentOrientation == 180)
            {
                _nextOrientation = -180;
            }
            _currentOrientation += _nextOrientation;
            transform.Rotate(0, 0, _nextOrientation, Space.Self);
        }
        else if(_currentDirection == Vector3.down)
        {
            if (_currentOrientation == 0)
            {
                _nextOrientation = 270;
            }
            else if (_currentOrientation == 90)
            {
                _nextOrientation = 180;
            }
            else if (_currentOrientation == 180)
            {
                _nextOrientation = 90;
            }
            _currentOrientation += _nextOrientation;
            transform.Rotate(0, 0, _nextOrientation, Space.Self);
        }
        else if (_currentDirection == Vector3.left)
        {
            if (_currentOrientation == 0)
            {
                _nextOrientation = 180;
            }
            else if (_currentOrientation == 90)
            {
                _nextOrientation = 90;
            }
            else if (_currentOrientation == 270)
            {
                _nextOrientation = -90;
            }
            _currentOrientation += _nextOrientation;
            transform.Rotate(0, 0, _nextOrientation, Space.Self);
        }
        else if(_currentDirection == Vector3.right)
        {
            if (_currentOrientation == 90)
            {
                _nextOrientation = -90;
            }
            else if (_currentOrientation == 180)
            {
                _nextOrientation = -180;
            }
            else if (_currentOrientation == 270)
            {
                _nextOrientation = -270;
            }
            _currentOrientation += _nextOrientation;
            transform.Rotate(0, 0, _nextOrientation, Space.Self);
        }

        
    }
}
