using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCollector : MonoBehaviour
{
    private List<GameObject> disabledPoints = new List<GameObject>();

    [SerializeField]
    private int _numOfPoints;

    [SerializeField]
    private ResetLevel reset;
    public void addDisabledPoint(GameObject point)
    {
        disabledPoints.Add(point);
        if (disabledPoints.Count >= _numOfPoints)
        {
            reset.resetLevel();
        }
    }
    public void removeAllDisabledPoint()
    {
        disabledPoints.Clear();
    }
    public List<GameObject> getDisabledPoints() 
    { 
        return disabledPoints;
    }
}
