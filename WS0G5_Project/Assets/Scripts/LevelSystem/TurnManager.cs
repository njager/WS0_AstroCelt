using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    private GlobalController global;
    public int turnCount;

    void Start()
    {
        global = GlobalController.instance; 
    }

    public void ConfirmButton()
    {
        ChangeTurn();
        ConstellationsToBeTriggered(global.FinalConstellationsFromTurn); 
    }

    public void ConstellationsToBeTriggered(List<int> _valueList)
    {

    }

    public bool enemyDefeated = false; // Put this in enemy

    public void ChangeTurn()
    {

    }

    public void TurnReset() // Trigger this in reset behavior 
    {
        if (enemyDefeated == true)
        {
            turnCount = 0; // Reset Turns
            global.enemySwitcherFrameworkScript.EnemySwitch();
            global.enemySwitcherFrameworkScript.ResetEnemies();
        }
        else
        {
            Debug.LogError("Enemy isn't dead!");
        }
    }
}
