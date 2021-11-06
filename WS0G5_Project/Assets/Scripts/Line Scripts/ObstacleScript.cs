using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    private GlobalController global;

    void Awake()
    {
        global = GlobalController.instance;
        global.obstacleList.Add(this); 
    }

    void OnDestroy()
    {
        Debug.Log("Cleared this obstacle");
        //global.obstacleList.Remove(this);
    }
}
