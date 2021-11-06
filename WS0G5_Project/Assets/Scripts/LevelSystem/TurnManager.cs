using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    private GlobalController global;
    public int totalTurnCount;
    public int playerTurnCount; 

    void Start()
    {
        global = GlobalController.instance;
        totalTurnCount = 0;
        playerTurnCount = 0; 
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
        totalTurnCount += 1;
        if (totalTurnCount % 2 == 0)
        {
            playerTurnCount += 1; 
        }
        global.currentEnemy.isYourTurn = false;
    }

    public void TurnReset() // Trigger this in reset behavior 
    {
        if (enemyDefeated == true)
        {
            totalTurnCount = 0; // Reset Turns
            global.enemySwitcherFrameworkScript.EnemySwitch();
            global.enemySwitcherFrameworkScript.ResetEnemies();
        }
        else
        {
            Debug.LogError("Enemy isn't dead!");
        }
    }
}
