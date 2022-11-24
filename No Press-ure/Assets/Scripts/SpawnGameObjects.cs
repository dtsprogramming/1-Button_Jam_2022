using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnGameObjects : MonoBehaviour
{
    [SerializeField] private float spawnDelay = 3;
    [SerializeField] private GameObject[] gameObjects;
    [SerializeField] private Transform[] spawnPoints;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRandomObject());
    }

    IEnumerator SpawnRandomObject()
    {
        GameObject thisObj = gameObjects[Random.Range(0, gameObjects.Length)];
        Transform spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];

        GameObject newObj = Instantiate(thisObj, spawnPoint.position, Quaternion.identity);

        yield return new WaitForSeconds(spawnDelay);

        StartCoroutine(SpawnRandomObject());
    }
}
