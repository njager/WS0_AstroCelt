using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySwitcherScript : MonoBehaviour
{
    public GameObject swarmPrefab;
    public GameObject legionaryPrefab;
    public GameObject lumberjackPrefab;
    public int deadCounter; 

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
        if (StaticVariables.masterEnemyCount == 5) // For later when ther's multiple enemies 
        {
            global.Win();
        }   
        if (global.currentEnemy.isDead == true)
        {
            if (deadCounter == 1)
            {
                Debug.LogWarning("Changing Enemies!");
                global.currentEnemy = global.enemy2;
            }
            if (deadCounter == 2)
            {
                global.currentEnemy = global.enemy3;
            }
        }
    }

    public void ResetEnemies()
    {
        StaticVariables.masterEnemyCount = 0;
    }

    public void EnemySwitch() // Use this to reset the level for when an enemy dies, and we need to switch over without re-instancing the scene. 
    {
        //global.resetBehavior.GameReset();
        if (StaticVariables.masterEnemyCount == 1) 
        {
            Debug.Log("Enemy Spawned!");
            Instantiate(swarmPrefab, global.enemySpawnPosition);
            return;
        }
        if (StaticVariables.masterEnemyCount == 2)
        {
            Debug.Log("Enemy Spawned!");
            Instantiate(legionaryPrefab, global.enemySpawnPosition);
        }
    }
}
