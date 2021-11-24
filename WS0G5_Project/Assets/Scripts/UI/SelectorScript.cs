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
    public bool enemy1Shielding;
    public bool enemy2Shielding;
    public bool enemy3Shielding;

    //private bool enemy1ActionSelected;
    //private bool enemy2ActionSelected;
    //private bool enemy3ActionSelected;

    public bool SelectorOff;

    [Header("Sprite Icons")]
    public Sprite enemyAttack;
    public Sprite enemyShield;

    void Start()
    {
        global = GlobalController.instance;
        enemy1Dead = false;
        enemy2Dead = false;
        enemy3Dead = false;
        enemy1Attacking = false;
        enemy2Attacking = false;
        enemy3Attacking = false;
        enemy1Shielding = false;
        enemy2Shielding = false;
        enemy3Shielding = false;

        EnemyActionNextTurn(global.enemy1ActionIcon);
        EnemyActionNextTurn(global.enemy2ActionIcon);
        EnemyActionNextTurn(global.enemy3ActionIcon);
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

    public void EnemyActionNextTurn(GameObject _givenEnemyIcon)
    {
        enemy1Attacking = false;
        enemy2Attacking = false;
        enemy3Attacking = false;
        enemy1Shielding = false;
        enemy2Shielding = false;
        enemy3Shielding = false;
        int _chanceSelected = ShieldChance();
        if (_chanceSelected > 3) // Set To Damage Next Turn
        {
            _givenEnemyIcon.GetComponent<SpriteRenderer>().sprite = enemyAttack;
            if (_givenEnemyIcon.CompareTag("Icon1") == true)
            {
                enemy1Attacking = true;
                return;
            }
            if (_givenEnemyIcon.CompareTag("Icon2") == true)
            {
                enemy2Attacking = true;
                return;
            }
            if (_givenEnemyIcon.CompareTag("Icon3") == true)
            {
                enemy1Attacking = true;
                return;
            }
        }
        else // Set To Shield
        {
            _givenEnemyIcon.GetComponent<SpriteRenderer>().sprite = enemyShield;
            if (_givenEnemyIcon.CompareTag("Icon1") == true)
            {
                enemy1Shielding = true;
                return;
            }
            if (_givenEnemyIcon.CompareTag("Icon2") == true)
            {
                enemy2Shielding = true;
                return;
            }
            if (_givenEnemyIcon.CompareTag("Icon3") == true)
            {
                enemy1Shielding = true;
                return;
            }
        }
    }

    public int ShieldChance() // This to see if indicators will change
    {
        int _chance = Random.Range(1, 11);
        return _chance;
    }


}
