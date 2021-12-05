using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    //private bool enemy1ActionSelected;
    //private bool enemy2ActionSelected;
    //private bool enemy3ActionSelected;

    [Header("Sprite Icons")]
    public Sprite enemyAttack;
    public Sprite enemyShield;
    public Image selectorGraphic;
    public GameObject selector; 

    public void Awake()
    {
        selectorGraphic = selector.GetComponent<Image>(); 
    }

    void Start()
    {
        global = GlobalController.instance;
        enemy1Dead = false;
        enemy2Dead = false;
        enemy3Dead = false;
        enemy1Attacking = true;
        enemy2Attacking = true;
        enemy3Attacking = true;
        global.turnManagerScript.Attacking();

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
                global.enemySelected = global.enemyNull;
                enemy1Dead = true;
            }
        }
        if (enemy2Dead == false)
        {
            if (StaticVariables.enemyCurrentHealth2 <= 0)
            {
                global.enemy2.enemyDie();
                global.enemySelected = global.enemyNull;
                enemy2Dead = true;
            }
        }
        if (enemy3Dead == false)
        {
            if (StaticVariables.enemyCurrentHealth3 <= 0)
            {
                global.enemy3.enemyDie();
                global.enemySelected = global.enemyNull; 
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
        if(global.enemy1ShieldCount < 0)
        {
            global.enemy1ShieldCount = 0;
        }
        if (global.enemy2ShieldCount < 0)
        {
            global.enemy2ShieldCount = 0;
        }
        if (global.enemy3ShieldCount < 0)
        {
            global.enemy3ShieldCount = 0;
        }
        
        if(global.enemySelected == global.enemyNull)
        {
            selector.SetActive(false);
        }
    }

    public void EnemyActionNextTurn(GameObject _givenEnemyIcon)
    {
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
                enemy3Attacking = true;
                return;
            }
        }
        else // Set To Shield
        {
            _givenEnemyIcon.GetComponent<SpriteRenderer>().sprite = enemyShield;
            if (_givenEnemyIcon.CompareTag("Icon1") == true)
            {
                enemy1Attacking = false;
                return;
            }
            if (_givenEnemyIcon.CompareTag("Icon2") == true)
            {
                enemy2Attacking = false;
                return;
            }
            if (_givenEnemyIcon.CompareTag("Icon3") == true)
            {
                enemy3Attacking = false;
                return;
            }
        }
    }

    public int ShieldChance() // This to see if indicators will change
    {
        int _chance = Random.Range(1, 11);
        return _chance;
    }

    // Doing Sound here since this is my defacto non-object based enemy script
    public void enemySoundChoosing()
    {
        int _enemy1Draw = Random.Range(1,4); // 3 Options
        global.enemy1Sound = _enemy1Draw; 
        if (_enemy1Draw == 1)
        {
            int _enemy2Draw = Random.Range(2, 4); // 2 Options
            global.enemy2Sound = _enemy2Draw;
            if (_enemy2Draw == 2)
            {
                global.enemy3Sound = 3; // Last option
            }
            else
            {
                global.enemy3Sound = 2; // Last option
            }
        }
        if (_enemy1Draw == 2)
        {
            int _enemy2Draw = Random.Range(1, 3); // 2 Options
            if (_enemy2Draw == 1)
            {
                global.enemy2Sound = _enemy2Draw;
                global.enemy3Sound = 3; // Last option
            }
            else
            {
                global.enemy3Sound = 1; // Last option
                global.enemy2Sound = 3;
            }
        }
        if (_enemy1Draw == 3)
        {
            int _enemy2Draw = Random.Range(1, 3); // 2 Options
            global.enemy2Sound = _enemy2Draw;
            if (_enemy2Draw == 1)
            {
                
                global.enemy3Sound = 2; // Last option
            }
            else
            {
                global.enemy3Sound = 1; // Last Option 
            }
        }
    }


}
