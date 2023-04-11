using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MC_InputMovements : MonoBehaviour
{
    public MC_Movement MC_Controller;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.W))
        {
            MC_Controller.changeDirection(Vector3.up);
            Debug.LogFormat("Direction changed to UP");
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            MC_Controller.changeDirection(Vector3.down);
            Debug.LogFormat("Direction changed to DOWN");
        }

        if(Input.GetKeyUp(KeyCode.D))
        {
            MC_Controller.changeDirection(Vector3.right);
            Debug.LogFormat("Direction changed to RIGHT");
        }

        if( Input.GetKeyUp(KeyCode.A))
        {
            MC_Controller.changeDirection(Vector3.left);
            Debug.LogFormat("Direction changed to LEFT");
        }
    }
}
