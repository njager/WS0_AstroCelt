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
        ChangeTurn();
    }

    public void ConfirmButton() // Not being used
    {
        FinishLinesColor(); 
        ChangeTurn();
    }

    public bool enemyDefeated = false; // Put this in enemy

    public void ChangeTurn()
    {
        global.drawingScript.starNext = global.drawingScript.NodeStar;
        //global.drawingScript.star2 = global.drawingScript.nodeStar2;
        global.drawingScript.starCount = 0;
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
