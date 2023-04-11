using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PointsTrigger : TriggerHandler
{
    [SerializeField]
    private PointCollector collector;
    protected override void internalOnTriggerEnter2D()
    {
        base.internalOnTriggerEnter2D();
        Debug.LogFormat("Point eated!");
        gameObject.SetActive(false);
        collector.addDisabledPoint(gameObject);
        Debug.LogFormat("Game object {0} set false", gameObject.name);
    }
}