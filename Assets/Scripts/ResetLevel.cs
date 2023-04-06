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
        if (collector != null && MC_Controller != null)
        {
            //Set speed to 0
            MC_Controller.changeDirection(Vector3.zero);
            //Set position to X=0, Y=0, Z=0
            MC_Controller.changePosition(startingPosition);
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
}
