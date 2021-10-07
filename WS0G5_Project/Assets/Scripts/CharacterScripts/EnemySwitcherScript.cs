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
        if (EnemyStats.enemyCount == 4) // For later when ther's multiple enemies 
        {
            global.Win(); 
        }   
    }
}
