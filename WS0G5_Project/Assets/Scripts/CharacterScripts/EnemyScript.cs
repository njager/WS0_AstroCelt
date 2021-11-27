using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.EventSystems;


public class EnemyScript : MonoBehaviour
{ 
    [Header("Enemy Attributes")]
    public EnemyStats myStats;
    public GameObject enemyGameObject;
    public EnemyScript enemySelf;
    public int turnsBetweenAttacks = 1;
    public string myIdentifier;
    public int enemyStartHealth; // Here to update info in UI Script, grabbed through global controller
    public int enemyShieldNum; 
    public bool isDead;
    
    [Header("Unique Behavior Variables")]
    public int _swarmAttackedAmount;
    public int legionaryEffectCounter;
    public bool _swarmDamageOrSpeed; // For the swarm, if there will be damage or speed chosen for the trigger, if false damage, if true speed
    public float randomFloat; // Can eventually change with system probability generator script
    public int _damageIndicator; // Used to see if the swarm was attacked in a single turn
    public bool _frenzyTriggered; // If false the frenzy isn't triggered, if true it ignores the checking behavior so as to not boost up continually 
   
    [Header("Enemy Varaibles")]
    public int enemyDamage; // Grab the damage from My Stats
    public int enemyHealth; // Grabing prefabed enemy health to modify for this specific enemy
    private GlobalController global; // Creating global variable
    public bool isYourTurn;
    //private float spawnTimer = 2.5f; // Have the enemy wait for a timer
   private bool iEnumeratorTriggered; // Need a bool to control timer IEnumerator
    public int turnActionCount = 0; // Need it so update keeps occuring but that it only riggers once, but can be triggered again in the future in the next turn

    void Awake() // Do this to set Enemy Count, and EnemyType
    {
        StaticVariables.masterEnemyCount += 1;
        myIdentifier = myStats.identifier; // Grabbing information from the data class during runtime
        isDead = false;
        int _randEnemyHealth = Random.Range(27, 36);
        enemyHealth = _randEnemyHealth;
        enemyStartHealth = _randEnemyHealth;
    }

    void Start()
    {
        //rate = 0.1f;
        Time.timeScale = 1f;
        global = GlobalController.instance;
        //global.currentEnemy = enemySelf;
        global.UIController.isEnemyDead = false;
        enemyDamage = myStats.damage;
        turnActionCount = 1;
        global.UIController.selector.SetActive(false); 
    }

    public void Update()
    {
        if (isYourTurn == true)
        {
            if(turnActionCount == 0)
            {
                turnActionCount += 1; 
                EnemyTurnAction();
            }
        }
        
    }

    private void OnMouseDown()
    {
        if (global.UIController.selector.activeInHierarchy != true)
        {
            Debug.Log("Moved!");
            global.UIController.selector.SetActive(true);
            Vector3 _newPosition = gameObject.transform.position;
            global.UIController.selector.transform.position = _newPosition;
            global.enemySelected = this;
        }
        else
        {
            Debug.Log("Moved!");
            Vector3 _newPosition = gameObject.transform.position;
            global.UIController.selector.transform.position = _newPosition;
            global.enemySelected = this; 
        }
        
    }

    public IEnumerator EnemyTurnTimer()
    {
        global.enemyTurnBar.SetActive(true);
        global.playerTurnBar.SetActive(false);
        Debug.Log("Happening!");
        isYourTurn = false;
        global.playerScript.isPlayerTurn = true;
        turnActionCount = 0; 
        yield return new WaitForSeconds(5f);
    }

    public void EnemyTurnAction() 
    {
        if (isYourTurn == true)
        {
            if (myIdentifier == "Enemy1")
            {
                if (global.turnManagerScript.totalTurnCount >= 1)
                {
                    global.enemy1.enemyAttacksPlayer(global.enemy1.enemyDamage);
                    global.m_SoundEffectDamage.Play();
                    iEnumeratorTriggered = true;
                    StartCoroutine(EnemyTurnTimer());
                    return;
                }
            }
            if (myIdentifier == "Enemy2")
            {
                if (global.turnManagerScript.totalTurnCount >= 1)
                {
                    global.enemy2.enemyAttacksPlayer(global.enemy2.enemyDamage);
                    global.m_SoundEffectDamage.Play();
                    iEnumeratorTriggered = true;
                    StartCoroutine(EnemyTurnTimer());
                    return;
                }
            }
            if (myIdentifier == "Enemy3")
            {
                if (global.turnManagerScript.totalTurnCount >= 1)
                {
                    global.enemy3.enemyAttacksPlayer(global.enemy3.enemyDamage);
                    global.m_SoundEffectDamage.Play();
                    iEnumeratorTriggered = true;
                    StartCoroutine(EnemyTurnTimer());
                    return;
                }
            }
        }
        else // If it's already false, keep it false
        {
            isYourTurn = false;
            global.playerScript.isPlayerTurn = true;
        }
        return; 
    }

    public void ResetBehavior() // Method of what to do in terms of reset/enemy switching 
    {
        Destroy(this);
    }

    public void OnDestroy() 
    {
        Debug.Log("Enemy Defeated"); // Logs Enemy Defeat
    }

    public void enemyAttacksPlayer(int damage) // Enemy Attack
    {
        global.playerScript.playerDamaged(damage);
        //Debug.Log("Enemy Attacks"); 
    }

    public void UniqueBehavior(string identity) 
    {
        if(identity == "Swarm")
        {
            if (_frenzyTriggered == false)
            {
                if (_swarmAttackedAmount > 5)
                {
                    _frenzyTriggered = true;
                    if (_swarmDamageOrSpeed == true)
                    {
                        turnsBetweenAttacks = (turnsBetweenAttacks / 2); // Double the speed at which the enemy attacks 
                    }
                    if (_swarmDamageOrSpeed == false)
                    {
                        enemyDamage = enemyDamage * 2; // Double the damage for the frenzy attacking 
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    Debug.Log("No Frenzy Yet");
                }
            }
            else
            {
                Debug.Log("Frenzy already triggered");
            }
            _swarmAttackedAmount = 0; 
        }
        if (identity == "Legionary")
        {
            if (legionaryEffectCounter == 0) // Makes it so the legionary only spawns a barrier once spawned in only once 
            {
                global.starSpawnerFrameworkScript.LegionaryEffect();
                legionaryEffectCounter += 1; 
            }
            else
            {
                return; 
            }
            
        }
    }

    public void enemyDie() // Death
    {
        StaticVariables.masterEnemyCount -= 1;
        gameObject.SetActive(false);
        //global.enemySwitcherFrameworkScript.EnemySwitch();
        //global.UIController.isEnemyDead = true;
        //Destroy(enemyGameObject)
        isDead = true;
        //global.currentEnemy.gameObject.SetActive(false);
        //global.enemySwitcherFrameworkScript.HCEnemySwitch();
    }

    public void EnemyDamaged(int _health) // Enemy is damaged, adjust numbers
    {
        if (myIdentifier == "Enemy1")
        {
            StaticVariables.enemyCurrentHealth1 -= _health;
        }
        if (myIdentifier == "Enemy2")
        {
            StaticVariables.enemyCurrentHealth2 -= _health;
        }
        if (myIdentifier == "Enemy3")
        {
            StaticVariables.enemyCurrentHealth3 -= _health;
        }

    }
}
