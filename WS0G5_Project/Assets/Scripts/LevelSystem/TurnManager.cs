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
        playerTurnCount = 0; 
    }

    public void EndTurn()
    {
        ChangeTurn();
        global.starSpawnerFrameworkScript.HCMapPicker(); 
    }

    public void ConfirmButton()
    {
        FinishLinesColor(); 
        ChangeTurn();
    }

    public bool enemyDefeated = false; // Put this in enemy

    public void ChangeTurn()
    {
        totalTurnCount += 1; // Fix later, lol
        playerTurnCount = totalTurnCount;
        global.currentEnemy.isYourTurn = true;
        global.currentEnemy.turnActionCount = 0;
        global.newStarMapScript.NewStarsPlayTest();
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
