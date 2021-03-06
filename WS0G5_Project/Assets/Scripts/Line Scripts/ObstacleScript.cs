using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq; 

public class ObstacleScript : MonoBehaviour
{
    public GameObject obstacleSelf;
    public ObstacleScript selfObstacleScript;
    private GlobalController global;

    public void Start()
    {
        global = GlobalController.instance;
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
