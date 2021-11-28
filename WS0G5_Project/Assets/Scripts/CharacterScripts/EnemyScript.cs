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
    public bool turnAction = false;
    private int firstActionCall;
    
    
    void Awake() // Do this to set Enemy Count, and EnemyType
    {
        StaticVariables.masterEnemyCount += 1;
        myIdentifier = myStats.identifier; // Grabbing information from the data class during runtime
        isDead = false;
        // Set Health
        int _randEnemyHealth = Random.Range(27, 36);
        enemyHealth = _randEnemyHealth;
        enemyStartHealth = _randEnemyHealth;
        // Set Damage
        int _randEnemyDamage = Random.Range(5, 8);
        enemyDamage = _randEnemyDamage; 
    }

    void Start()
    {
        //rate = 0.1f;
        Time.timeScale = 1f;
        global = GlobalController.instance;
        //global.currentEnemy = enemySelf;
        global.UIController.isEnemyDead = false;
        //enemyDamage = myStats.damage;
        turnActionCount = 1;
        global.UIController.selector.SetActive(false);
        firstActionCall = -1;
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
        if (global.enemy1.isYourTurn == false)
        {
            if (global.enemy2.isYourTurn == false)
            {
                if (global.enemy3.isYourTurn == false)
                {
                    global.playerScript.isPlayerTurn = true;
                }
                else
                {
                    global.playerTurnBar.SetActive(false);
                    global.enemyTurnBar.SetActive(true);
                    global.playerScript.isPlayerTurn = false;
                }
            }
            else
            {
                global.playerTurnBar.SetActive(false);
                global.enemyTurnBar.SetActive(true);
                global.playerScript.isPlayerTurn = false;
            }
        }
        else
        {
            global.playerTurnBar.SetActive(false);
            global.enemyTurnBar.SetActive(true);
            global.playerScript.isPlayerTurn = false;
        }
        if (firstActionCall == 0)
        {
            StartCoroutine(EnemyTurnTimer());
        }
        if (turnAction == true)
        {
            //Debug.Log("Happening!");
            isYourTurn = false;
            turnActionCount = 0;
            turnAction = false;
            firstActionCall++;
            return;
        }

        if(myIdentifier == "Enemy 1")
        {
            if (global.enemy1Attacking == true)
            {
                global.enemy1ShieldGraphic.SetActive(false);
                global.enemy1ShieldUI.SetActive(false);
            }
            else
            {
                global.enemy1ShieldGraphic.SetActive(true);
                global.enemy1ShieldUI.SetActive(true);
            }
        }

        if (myIdentifier == "Enemy 2")
        {
            if (global.enemy2Attacking == true)
            {
                global.enemy2ShieldGraphic.SetActive(false);
                global.enemy2ShieldUI.SetActive(false);
            }
            else
            {
                global.enemy2ShieldGraphic.SetActive(true);
                global.enemy2ShieldUI.SetActive(true);
            }
        }

        if (myIdentifier == "Enemy 3")
        {
            if (global.enemy3Attacking == true)
            {
                global.enemy3ShieldGraphic.SetActive(false);
                global.enemy3ShieldUI.SetActive(false);
            }
            else
            {
                global.enemy3ShieldGraphic.SetActive(true);
                global.enemy3ShieldUI.SetActive(true);
            }
        }
    }


    public void UpdateDamage()
    {
        int _randEnemyDamage = Random.Range(5, 9);
        enemyDamage = _randEnemyDamage;
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
        yield return new WaitForSeconds(3f);
        turnAction = true;
    }


    public void EnemyTurnAction() 
    {
        if (isYourTurn == true)
        {
            if (myIdentifier == "Enemy1")
            {
                if (global.turnManagerScript.totalTurnCount >= 1)
                {
                    if(global.enemy1Attacking == true)
                    {
                        global.enemy1.enemyAttacksPlayer(global.enemy1.enemyDamage);
                        global.particleSystemScript.SpawnDamageParticleEffect(global.enemyHealthBar1);
                        Popup.Create(global.enemyHealthBar1.position, enemyDamage, 1, true);
                        global.m_SoundEffectDamage.Play();
                        firstActionCall = 0;
                    }
                    else
                    {
                        Debug.Log("Enemy1 is now Shielded");
                        firstActionCall = 0;
                    }
                }
            }
            if (myIdentifier == "Enemy2")
            {
                if (global.turnManagerScript.totalTurnCount >= 1)
                {
                    if(global.enemy2Attacking == true)
                    {
                        global.enemy2.enemyAttacksPlayer(global.enemy2.enemyDamage);
                        global.particleSystemScript.SpawnDamageParticleEffect(global.enemyHealthBar2);
                        Popup.Create(global.enemyHealthBar1.position, enemyDamage, 1, true);
                        global.m_SoundEffectDamage.Play();
                        firstActionCall = 0;
                    }
                    else
                    {
                        Debug.Log("Enemy2 is now Shielded");
                        firstActionCall = 0;
                    }
                }
            }
            if (myIdentifier == "Enemy3")
            {
                if (global.turnManagerScript.totalTurnCount >= 1)
                {
                    if (global.enemy3Attacking == true)
                    {
                        global.enemy3.enemyAttacksPlayer(global.enemy3.enemyDamage);
                        global.particleSystemScript.SpawnDamageParticleEffect(global.enemyHealthBar3);
                        Popup.Create(global.enemyHealthBar3.position, enemyDamage, 1, true);
                        global.m_SoundEffectDamage.Play();
                        firstActionCall = 0;
                    }
                    else
                    {
                        Debug.Log("Enemy3 is now Shielded!");
                        firstActionCall = 0;
                    }
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

    public void enemyDie() // Death
    {
        StaticVariables.masterEnemyCount -= 1;
        isDead = true;
        isYourTurn = false; 
        gameObject.SetActive(false);
        //global.enemySwitcherFrameworkScript.EnemySwitch();
        //global.UIController.isEnemyDead = true;
        //Destroy(enemyGameObject)
        //global.currentEnemy.gameObject.SetActive(false);
        //global.enemySwitcherFrameworkScript.HCEnemySwitch();
    }

    public void EnemyDamaged(int _health) // Enemy is damaged, adjust numbers
    {
        if (myIdentifier == "Enemy1")
        {
            if (global.enemy1Shielded)
            {
                global.enemy1ShieldCount -= 1;
            }
            else
            {
                StaticVariables.enemyCurrentHealth1 -= _health;
            }
        }
        if (myIdentifier == "Enemy2")
        {
            if(global.enemy2Shielded)
            {
                global.enemy2ShieldCount -= 1;
            }
            else
            {
                StaticVariables.enemyCurrentHealth2 -= _health;
            }
        }
        if (myIdentifier == "Enemy3")
        {
            if (global.enemy3Shielded)
            {
                global.enemy3ShieldCount -= 1;
            }
            else
            {
                StaticVariables.enemyCurrentHealth3 -= _health;
            }
        }
    }

    public void UniqueBehavior(string identity)
    {
        if (identity == "Swarm")
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
}
