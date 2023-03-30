using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEditor;
using UnityEngine;

public class SpawnPoints : MonoBehaviour
{
    [SerializeField]
    private int _numToSpawnX = 25;
    [SerializeField]
    private int _numToSpawnY = 25;
    [SerializeField]
    private float spawnOffsetX = 0.76f;
    [SerializeField]
    private float spawnOffsetY= 0.75f;
    [SerializeField]
    private GameObject prefab;

    private float currentSpawnOffsetX;
    private float currentSpawnOffsetY;


    // Start is called before the first frame update
    void Start()
    {
        currentSpawnOffsetY = 0;
        currentSpawnOffsetX = spawnOffsetX;
        for (int j = 0; j < _numToSpawnY; j++)
        {
            currentSpawnOffsetX = 0;
            for(int i = 0; i < _numToSpawnX; i++)
            {
                //Clone
                GameObject clonePoint = Instantiate(prefab,
                    new Vector3(transform.position.x + currentSpawnOffsetX, transform.position.y + currentSpawnOffsetY, 0),
                    Quaternion.identity);
                currentSpawnOffsetX += spawnOffsetX;
            }
            currentSpawnOffsetX = 0;
            currentSpawnOffsetY += spawnOffsetY;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
