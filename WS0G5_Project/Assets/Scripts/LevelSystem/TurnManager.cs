using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    private GlobalController global;
    private int _turnCount;

    // Start is called before the first frame update
    void Start()
    {
        _turnCount = Stars.turnCount; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool enemyDefeated = false; // Put this in enemy

    public void TurnReset() // Trigger this in reset behavior 
    {
        if (enemyDefeated == true)
        {
            _turnCount = 0; // Reset Turns
            global.enemySwitcherFrameworkScript.EnemySwitch();
            global.enemySwitcherFrameworkScript.ResetEnemies();
        }
        else
        {
            Debug.LogError("Enemy isn't dead!");
        }
    }
}
