using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinBehavior : MonoBehaviour
{
    private GlobalController global;

    void Start()
    {
        global = GlobalController.instance;
    }

    void Update()
    {
        if(StaticVariables.enemyCurrentHealth < 0)
        {
            global.Win(); // For now
        }
    }
}
