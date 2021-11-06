using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ResetBehavior : MonoBehaviour
{
    private GlobalController global;
    private int iEnumeratorVariable; // Using to trigger out of the function
    void Start()
    {
        global = GlobalController.instance; 
    }

    // Update is called once per frame
    public void GameReset()
    {
        iEnumeratorVariable = 1; 
        StartCoroutine(GameResetCoroutine()); // Stop the frame counts before we use our own update loop
    }
    public void TurnReset() // Trigger this in reset behavior 
    {
        if (global.turnManagerScript.enemyDefeated == true)
        {
            global.turnManagerScript.totalTurnCount = 0; // Reset Turns
            global.enemySwitcherFrameworkScript.EnemySwitch();
            global.enemySwitcherFrameworkScript.ResetEnemies();
        }
        else
        {
            Debug.LogError("Enemy isn't dead!");
        }
    }

    IEnumerator GameResetCoroutine()
    {
        global.starSpawnerFrameworkScript.FrameworkReset();
        foreach (LineRendererScript line in global.lineRendererResetList.ToList())
        {
            line.ResetList();
        }
        global.drawingScript.ResetList(); // Reset All Lines
        iEnumeratorVariable = 0;
        yield return new WaitUntil(() => iEnumeratorVariable == 0);
    }
}
