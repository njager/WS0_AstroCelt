using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq; 

public class ObstacleScript : MonoBehaviour
{
    private GlobalController global;
    public GameObject obstacleSelf;
    public ObstacleScript myObstacleScript; 

    void Awake()
    {
        global = GlobalController.instance;
    }

    private void Start()
    {
        global.obstacleList.Add(myObstacleScript);
    }

    public void Clearing()
    {
        global.obstacleList.Remove(this);
        Destroy(obstacleSelf);
    }

    void OnDestroy()
    {
        Debug.Log("Cleared this obstacle");
    }
}
