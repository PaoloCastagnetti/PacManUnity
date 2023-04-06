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
    }
    public void removeAllDisabledPoint()
    {
        disabledPoints.Clear();
    }
    public List<GameObject> getDisabledPoints() 
    { 
        return disabledPoints;
    }

    private void Update()
    {
        if(disabledPoints.Count >= _numOfPoints)
        {
            reset.resetLevel();
        }
    }
}
