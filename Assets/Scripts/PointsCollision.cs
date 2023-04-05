using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PointsCollision : TriggerHandler
{
    [SerializeField]
    private GameObject collector;
    protected override void internalOnTriggerEnter2D()
    {
        base.internalOnTriggerEnter2D();
        Debug.LogFormat("Point eated!");

        PointCollector pointCollector = collector.GetComponent<PointCollector>();
        pointCollector.addDisabledPoint(gameObject);

        Debug.LogFormat("Game object {0} set false", gameObject.name);
        gameObject.SetActive(false);
    }
}
