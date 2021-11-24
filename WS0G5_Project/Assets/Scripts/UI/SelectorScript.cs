using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorScript : MonoBehaviour
{

    /// <summary>
    /// Using this script to keep track of dead enemies and what enemy is selected
    /// 
    /// Enemies get 2 Shields to Start with - block whole attacks
    /// </summary>
   
    private GlobalController global;
    private bool enemy1Dead;
    private bool enemy2Dead;
    private bool enemy3Dead;

    [Header("Enemy Bools")]
    public bool enemy1Attacking;
    public bool enemy2Attacking;
    public bool enemy3Attacking;

    void Start()
    {
        global = GlobalController.instance;
        enemy1Dead = false;
        enemy2Dead = false;
        enemy3Dead = false;
    }

    void Update() // Track Enemy Health
    {
        if (enemy1Dead == false)
        {
            if (StaticVariables.enemyCurrentHealth1 <= 0)
            {
                global.enemy1.enemyDie();
                enemy1Dead = true;
            }
        }
        if (enemy2Dead == false)
        {
            if (StaticVariables.enemyCurrentHealth2 <= 0)
            {
                global.enemy2.enemyDie();
                enemy2Dead = true;
            }
        }
        if (enemy3Dead == false)
        {
            if (StaticVariables.enemyCurrentHealth3 <= 0)
            {
                global.enemy3.enemyDie();
                enemy3Dead = true;
            }
        }
        if (global.enemy3.enemyHealth <= 0)
        {
            if (global.enemy2.enemyHealth <= 0)
            {
                if (global.enemy1.enemyHealth <= 0)
                {
                    global.Win();
                }
            }
        }
    }

    public int ShieldChance() // This to see if indicators will change
    {
        int _chance = Random.Range(1, 11);
        return _chance;
    }
}
