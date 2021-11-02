using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class Stars : MonoBehaviour
{
    [Header("Star Attributes")]
    public StarClass myStarClass;
    public bool starUsed = false;
    public bool starFullyUsed = false;
    public GameObject starSelf;
    public GameObject starGraphicSelf;
    public Color hoverColor;
    public Color usedColor;
    public Vector3 positionOffset;
    public GameObject starGraphic;

    //Global Setting
    private GlobalController global;

    // Private Variables
    private SpriteRenderer rend;
    private Color startColor;

    public void Start()
    {
        global = GlobalController.instance;

        starUsed = false;
        global.ListCount++;
        Debug.Log("Star Added");

        rend = starGraphicSelf.GetComponent<SpriteRenderer>();
        startColor = rend.material.color;
    }

    public void OnMouseEnter()
    {
        rend.material.color = hoverColor;
    }

    public void OnMouseExit()
    {
        rend.material.color = startColor;
    }

    public void StarUsed()
    {
        rend.material.color = usedColor;
        startColor = usedColor;
        hoverColor = usedColor;
        starFullyUsed = true;
        return;
    }

    public void StunStarAbility()
    {
        if (myStarClass.starType == "StunStar")
        {
            //PlayerStats.
        }
    }

    public void ShieldStarAbility()
    {
        if (myStarClass.starType == "ShieldStar")
        {

        }
    }

    public static int turnCount; // Use this to determine action
    public static int internalCount;
    public bool isYourTurn; // If false, your turn is not happening

    //Estimated turn count needed to defeat an enemy
    //
    //
    // In Awake(), _currentTurn, reference _currentTurn for multi-turn actions 

    public void EnemyTurnAction() // Put this in enemy 
    {
        if (isYourTurn == false)
        {
            if (myStarClass.starType == "Legionary")
            {
                if (turnCount == 1)
                {
                    global.currentEnemy.enemyAttacksPlayer(global.currentEnemy.enemyDamage);
                    global.currentEnemy.UniqueBehavior(global.currentEnemy.myIdentifier); 
                }
                if (turnCount > 1)
                {
                    global.currentEnemy.enemyAttacksPlayer(global.currentEnemy.enemyDamage);
                    global.currentEnemy.UniqueBehavior(global.currentEnemy.myIdentifier);
                }
            }
            if (myStarClass.starType == "Swarm")
            {
                if (turnCount == 1)
                {
                    global.currentEnemy.enemyAttacksPlayer(global.currentEnemy.enemyDamage);
                    global.currentEnemy.UniqueBehavior(global.currentEnemy.myIdentifier);
                }
                if (turnCount > 1)
                {
                    global.currentEnemy.enemyAttacksPlayer(global.currentEnemy.enemyDamage);
                    global.currentEnemy.UniqueBehavior(global.currentEnemy.myIdentifier);
                }
            }
            if (myStarClass.starType == "Lumberjack")
            {
                if (turnCount == 1)
                {
                    global.currentEnemy.enemyAttacksPlayer(global.currentEnemy.enemyDamage);
                    global.currentEnemy.UniqueBehavior(global.currentEnemy.myIdentifier);
                }
                if (turnCount > 1)
                {
                    global.currentEnemy.enemyAttacksPlayer(global.currentEnemy.enemyDamage);
                    global.currentEnemy.UniqueBehavior(global.currentEnemy.myIdentifier);
                }
            }
        }
        
        isYourTurn = true; 
    }

    // Use Fixed Update over update

    // Bring back the idea of confirmation button 

    // Turns for enemies need to lock out player, trigger bools, coroutine? Every end turn button

    // Use bools to invalidate turns

    //Space bar ends turn
    //Calculate area of the branches before adding their value
    //Line value is now the determiner of the constellation value 

    // Node idea,yes, how many nodes, how many branches can come off the node? Are these limited?
    // Polygons

    // All stars can only have two lines touching

    // Create a prefab called a node star, can the node be placed?

    //Change enemy to turnbased 

}
