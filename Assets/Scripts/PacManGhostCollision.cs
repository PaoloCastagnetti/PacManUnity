using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacManGhostCollision : CollisionHandler
{
    public MC_Movement MC_Controller;
    public Ghost_Movement Ghost_Controller;
    
    [SerializeField]
    private Vector3 _randomDirection;

    [SerializeField]
    private ResetLevel reset;

    private int _randomNum;
    private Vector3 _currentDirection;

    protected override void internalOnCollisionEnter2D(Collision2D collision)
    {
        base.internalOnCollisionEnter2D(collision);
        _currentDirection = Ghost_Controller.getCurrentdirection();

        if (collision.collider.gameObject != MC_Controller.gameObject)
        {
            do
            {
                _randomNum = Random.Range(0, 4);
                switch (_randomNum)
                {
                    case 0:
                        _randomDirection = Vector3.up;
                        break;
                    case 1:
                        _randomDirection = Vector3.down;
                        break;
                    case 2:
                        _randomDirection = Vector3.left;
                        break;
                    case 3:
                        _randomDirection = Vector3.right;
                        break;
                    default:
                        _randomDirection = Vector3.zero;
                        break;
                }
            } while(_randomDirection == _currentDirection);
            
            Ghost_Controller.changeDirection(_randomDirection);
        }
        else
        {
            reset.resetLevel();
        }

        // Debug.LogFormat("Direction changed to ZERO");
    }
}
