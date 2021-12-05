using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.EventSystems;


public class EnemyScript : MonoBehaviour
{ 
    [Header("Enemy Attributes")]
    public EnemyStats myStats;
    public GameObject enemyGameObject; // Selfreference to specific game object
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
        int _randEnemyHealth = Random.Range(27, 37);
        enemyHealth = _randEnemyHealth;
        enemyStartHealth = _randEnemyHealth;
        // Set Damage
        int _randEnemyDamage = Random.Range(6, 12);
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
        }

        if(myIdentifier == "Enemy1")
        {
            if (global.enemy1Attacking == true)
            {
                global.enemy1ShieldGraphic.SetActive(false);
                global.enemy1ShieldUI.SetActive(false);
            }
            if (global.enemy1Attacking == false)
            {
                global.enemy1ShieldGraphic.SetActive(true);
                global.enemy1ShieldUI.SetActive(true);
            }
        }

        if (myIdentifier == "Enemy2")
        {
            if (global.enemy2Attacking == true)
            {
                global.enemy2ShieldGraphic.SetActive(false);
                global.enemy2ShieldUI.SetActive(false);
            }
            if (global.enemy2Attacking == false)
            {
                global.enemy2ShieldGraphic.SetActive(true);
                global.enemy2ShieldUI.SetActive(true);
            }
        }

        if (myIdentifier == "Enemy3")
        {
            if (global.enemy3Attacking == true)
            {
                global.enemy3ShieldGraphic.SetActive(false);
                global.enemy3ShieldUI.SetActive(false);
            }
            if (global.enemy3Attacking == false)
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
        if (isDead == true)
        {
            return;
        }
    }

    public IEnumerator EnemyTurnTimer()
    {
        yield return new WaitForSeconds(3f);
        turnAction = true;
    }

    /// <summary>
    /// The enemy turns aren't perfect since it's triggering 3 different waiting coroutines rather than 1 full call that would really be more graceful,
    /// it's fine for now, but a state machine controller would be a much better way to trigger enemy behavior in the remake
    /// </summary>

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
                        global.popup.Create(global.enemyHealthBar1.position, enemyDamage, 1, true);

                        if (global.enemy1Sound == 1) // If it's 1
                        {
                            global.m_SoundEffectDamage.Play(); 
                        }
                        if (global.enemy1Sound == 2) // If it's 2
                        {
                            global.m_SoundEffectDamageSlice1.Play();
                        }
                        if (global.enemy1Sound == 3) // If it's 3
                        {
                            global.m_SoundEffectDamageSlice2.Play();
                        }
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
                        global.popup.Create(global.enemyHealthBar2.position, enemyDamage, 1, true);
                        if (global.enemy2Sound == 1) // If it's 1
                        {
                            global.m_SoundEffectDamage.PlayDelayed(0.5f);
                        }
                        if (global.enemy2Sound == 2) // If it's 2
                        {
                            global.m_SoundEffectDamageSlice1.PlayDelayed(0.5f);
                        }
                        if (global.enemy2Sound == 3) // If it' 3
                        {
                            global.m_SoundEffectDamageSlice2.PlayDelayed(0.5f);
                        }
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
                        global.popup.Create(global.enemyHealthBar3.position, enemyDamage, 1, true);
                        if (global.enemy2isDead != true) // Just enemy 1 dying should allow the 2 to be in better lockstep with eachother
                        {
                            if (global.enemy3Sound == 1) // If it's 1
                            {
                                global.m_SoundEffectDamage.PlayDelayed(1f);
                            }
                            if (global.enemy3Sound == 2) // If it' 2
                            {
                                global.m_SoundEffectDamageSlice1.PlayDelayed(1f);
                            }
                            if (global.enemy3Sound == 3) // If it' 3
                            {
                                global.m_SoundEffectDamageSlice2.PlayDelayed(1f);
                            }
                        }
                        else
                        {
                            if (global.enemy3Sound == 1) // If it's 1
                            {
                                global.m_SoundEffectDamage.PlayDelayed(0.5f);
                            }
                            if (global.enemy3Sound == 2) // If it' 2
                            {
                                global.m_SoundEffectDamageSlice1.PlayDelayed(0.5f);
                            }
                            if (global.enemy3Sound == 3) // If it' 3
                            {
                                global.m_SoundEffectDamageSlice2.PlayDelayed(0.5f);
                            }
                        }
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

    // no longer occurs, enemy isn't destroyed
    public void OnDestroy() 
    {
        Debug.Log("Enemy Defeated"); // Logs Enemy Defeat
    }

    public void enemyAttacksPlayer(int damage) // Enemy Attack
    {
        global.playerScript.playerDamaged(damage);
        //Debug.Log("Enemy Attacks"); 
    }

    public void OnMouseOver()
    {

    }

    public void OnMouseExit()
    {

    }

    public void enemyDie() // Death
    {
        StaticVariables.masterEnemyCount -= 1;
        isDead = true;
        isYourTurn = false;
        if(myIdentifier == "Enemy1")
        {
            global.enemy1UI.SetActive(false);
            global.enemy1isDead = true; 
        }
        if (myIdentifier == "Enemy2")
        {
            global.enemy2UI.SetActive(false);
            global.enemy2isDead = true;
        }
        if (myIdentifier == "Enemy3")
        {
            global.enemy3UI.SetActive(false);
            global.enemy3isDead = true;
        }
        Debug.Log("Enemy Defeated");
        global.enemySelected = global.enemyNull;
        gameObject.SetActive(false);
        //global.enemySwitcherFrameworkScript.EnemySwitch();
        //global.UIController.isEnemyDead = true;
        //Destroy(enemyGameObject)
        //global.currentEnemy.gameObject.SetActive(false);
        //global.enemySwitcherFrameworkScript.HCEnemySwitch();
    }

    public void EnemyDamaged(int _damage) // Enemy is damaged, adjust numbers
    {
        if (myIdentifier == "Enemy1")
        {
            if(global.enemy1Attacking == true)
            {
                StaticVariables.enemyCurrentHealth1 -= _damage;
            }
            else
            {
                int _check = _damage - global.enemy1ShieldCount;
                if(global.enemy1ShieldCount > 0)
                {
                    global.enemy1ShieldCount -= _damage;
                }
                if(_check > 0)
                {
                    StaticVariables.enemyCurrentHealth1 -= _damage;
                }
            }
        }
        if (myIdentifier == "Enemy2")
        {
            if(global.enemy2Attacking == true)
            {
                StaticVariables.enemyCurrentHealth2 -= _damage;
            }
            else
            {
                int _check = _damage - global.enemy2ShieldCount;
                if (global.enemy2ShieldCount > 0)
                {
                    global.enemy2ShieldCount -= _damage;
                }
                if (_check > 0)
                {
                    StaticVariables.enemyCurrentHealth2 -= _damage;
                }
            }
        }
        if (myIdentifier == "Enemy3")
        {
            if (global.enemy3Attacking == true)
            {
                StaticVariables.enemyCurrentHealth3 -= _damage;
            }
            else
            {
                int _check = _damage - global.enemy3ShieldCount;
                if (global.enemy3ShieldCount > 0)
                {
                    global.enemy3ShieldCount -= _damage;
                }
                if (_check > 0)
                {
                    StaticVariables.enemyCurrentHealth3 -= _damage;
                }
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
