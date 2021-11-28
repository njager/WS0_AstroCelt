using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq; 

public class TurnManager : MonoBehaviour
{
    private GlobalController global;
    public int totalTurnCount;
    public int playerTurnCount; 

    void Start()
    {
        global = GlobalController.instance;
        totalTurnCount = 1;
        playerTurnCount = totalTurnCount; 
    }

    public void EndTurn() // Being used
    {
        if (global.UIController.selector.activeInHierarchy != true)
        {
            Debug.Log("PLEASE SELECT AN ENEMY BEFORE ENDING YOUR TURN");
            return;
        }
        if(global.playerScript.isPlayerTurn != true)
        {
            Debug.Log("IT'S NOT YOUR TURN YET");
            return;
        }
        ChangeTurn();
    }

    void ChangeEnemyDamage()
    {
        global.enemy1.UpdateDamage();
        global.enemy2.UpdateDamage();
        global.enemy3.UpdateDamage();
    }

    public void ConfirmButton() // Not being used
    {
        FinishLinesColor(); 
        ChangeTurn();
    }

    public bool enemyDefeated = false; // Put this in enemy

    public void ChangeTurn()
    {
        ChangeEnemyDamage();
        Attacking();
        global.drawingScript.starNext = global.drawingScript.NodeStar;
        //global.drawingScript.star2 = global.drawingScript.nodeStar2;
        global.drawingScript.starCount = 1;
        totalTurnCount += 1; 
        playerTurnCount = totalTurnCount;
        global.starSpawnerFrameworkScript.HCMapPicker();
        global.AltarSelection();
        global.enemy1.turnActionCount = 0;
        global.enemy2.turnActionCount = 0;
        global.enemy3.turnActionCount = 0;
        global.enemy1.isYourTurn = true;
        global.enemy2.isYourTurn = true;
        global.enemy3.isYourTurn = true;
        //global.drawingScript.activeStarCounter = 1;
        foreach (Star star in global.constellationBeingBuilt.ToList())
        {
            global.constellationBeingBuilt.Remove(star);
        }
        foreach (LineRendererScript line in global.lineRendererList.ToList())
        {
            line.gameObject.SetActive(false);
            global.lineRendererList.Remove(line);
        }
        global.selector.EnemyActionNextTurn(global.enemy1ActionIcon);
        global.selector.EnemyActionNextTurn(global.enemy2ActionIcon);
        global.selector.EnemyActionNextTurn(global.enemy3ActionIcon);
    }

    public void Attacking()
    {
        if (global.selector.enemy1Attacking == true)
        {
            global.enemy1Attacking = true;
            global.enemy1Shielded = false;
        }
        if (global.selector.enemy1Attacking == false)
        {
            global.enemy1Attacking = false;
            global.enemy1Shielded = true;
        }
        if (global.selector.enemy2Attacking == true)
        {
            global.enemy2Attacking = true;
            global.enemy2Shielded = false;
        }
        if (global.selector.enemy2Attacking == false)
        {
            global.enemy2Attacking = false;
            global.enemy2Shielded = true;
        }
        if (global.selector.enemy3Attacking == true)
        {
            global.enemy3Attacking = true;
            global.enemy3Shielded = false;
        }
        if (global.selector.enemy3Attacking == false)
        {
            global.enemy3Attacking = false;
            global.enemy3Shielded = true;
        }
    }


    // Should take all the lines and change their color to white
    public void FinishLinesColor()
    {
        foreach(LineRendererScript _lines in global.lineRendererList.ToList())
        {
            LineRenderer colorChanger; 
            colorChanger = _lines.gameObject.GetComponent<LineRenderer>();
            colorChanger.startColor = Color.white;
            colorChanger.endColor = Color.white;
        }
    }
}
