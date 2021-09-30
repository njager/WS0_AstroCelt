using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class StarSpawner : MonoBehaviour
{
    public GameObject starPrefab;
    public int starSpawnCount;

    [Header("Row 1")]
    public Transform starSpawnPoint1_1;
    public Transform starSpawnPoint2_1;
    public Transform starSpawnPoint3_1;

    

    void Start()
    {
        starSpawnCount = 0; 
    }

    void Update()
    {
        SpawnStar(starPrefab);
    }

    void SpawnStar(GameObject star)
    {
        if (starSpawnCount == 0)
        {
            Instantiate(star, spawnPoint1.position, spawnPoint1.rotation);
            Debug.Log("Star Spawned!");
            starSpawnCount++;
        }
        if (starSpawnCount == 1)
        {
            Instantiate(star, spawnPoint2.position, spawnPoint2.rotation);
            Debug.Log("Star Spawned!");
            starSpawnCount++;
        }
        if (starSpawnCount == 2)
        {
            Instantiate(star, spawnPoint3.position, spawnPoint3.rotation);
            Debug.Log("Star Spawned!");
            starSpawnCount++;
        }
    }
}
