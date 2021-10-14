using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySwitcherScript : MonoBehaviour
{
    // Use this script to switch out enemies upon their death; 
    private GlobalController global;

    // Start is called before the first frame update
    void Start()
    {
        global = GlobalController.instance;
    }

    // Update is called once per frame
    void Update()
    {
        if (StaticVariables.masterEnemyCount == 4) // For later when ther's multiple enemies 
        {
            global.Win(); 
        }   
    }

    public void ResetEnemies()
    {
        StaticVariables.masterEnemyCount = 0;
    }

    public void EnemySwitch() // Use this to reset the level for when an enemy dies, and we need to switch over without re-instancing the scene. 
    {
        global.resetBehavior.GameReset(); 
    }
}
