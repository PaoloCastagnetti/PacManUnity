using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ResetLevel : MonoBehaviour
{
    [SerializeField]
    private PointCollector collector;
    [SerializeField]
    private MC_movement MC_Controller;

    [SerializeField]
    private Vector3 startingPosition;

    public void resetLevel()
    {   
        //Set position
        MC_Controller.changePosition(startingPosition);
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
