using UnityEngine;

public class SpawnPoints : MonoBehaviour {
    [SerializeField]
    private int _numToSpawnX;
    [SerializeField]
    private int _numToSpawnY;
    [SerializeField]
    private float spawnOffsetX;
    [SerializeField]
    private float spawnOffsetY;
    [SerializeField]
    private GameObject prefab;

    private float currentSpawnOffsetX;
    private float currentSpawnOffsetY;


    // Start is called before the first frame update
    void Start() {
        currentSpawnOffsetY = 0;
        currentSpawnOffsetX = spawnOffsetX;
        for (int j = 0; j < _numToSpawnY; j++) {
            currentSpawnOffsetX = 0;
            for (int i = 0; i < _numToSpawnX; i++) {
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
    void Update() {

    }
}
