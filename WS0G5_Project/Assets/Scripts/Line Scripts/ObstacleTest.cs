using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleTest : MonoBehaviour
{
    public GameObject obstacleSelf;
    public ObstacleTest selfObstacleScript;
    private GlobalController global;

    public void Awake()
    {
        global = GlobalController.instance;
    }

    public void Start()
    {
        global.obstacleList.Add(this.gameObject);
    }

    public void Clearing()
    {
        global.obstacleList.Remove(gameObject);
        Destroy(gameObject);
    }

    public void OnDestroy()
    {
        global.obstacleList.Remove(this.gameObject);
        Debug.Log("Cleared this obstacle.");
    }
}
