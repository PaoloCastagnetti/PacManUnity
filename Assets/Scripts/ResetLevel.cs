using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ResetLevel : MonoBehaviour
{
    [SerializeField]
    private PointCollector collector;
    [SerializeField]
    private MC_Movement MC_Controller;
    [SerializeField]
    private Ghost_Movement Ghost_ControllerBlu;
    [SerializeField]
    private Ghost_Movement Ghost_ControllerGreen;

    [SerializeField]
    private Vector3 startingPosition;
    [SerializeField]
    private Vector3 startingBluPosition;
    [SerializeField]
    private Vector3 startingGreenPosition;

    public void resetLevel()
    {   
        //Set position
        MC_Controller.changePosition(startingPosition);
        Ghost_ControllerBlu.changePosition(startingBluPosition);
        Ghost_ControllerGreen.changePosition(startingGreenPosition);

        //Set speed to 0
        MC_Controller.changeDirection(Vector3.zero);
        //Getting all disabled points
        List<GameObject> disabledPoints = collector.getDisabledPoints();
        //Re-enable all the points
        Debug.LogFormat("Disabled points: {0}", disabledPoints[0]);
        foreach (GameObject point in disabledPoints)
        {
            if (point != null)
            {
                point.gameObject.SetActive(true);
            }
        }
        collector.removeAllDisabledPoint();
    }
}
