using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{ 
    [Header("Enemy Attributes")]
    public EnemyStats myStats;
    public GameObject enemyGameObject;
    public EnemyScript enemySelf;
    public float timeBetweenAttacks = 2f;
    public string myIdentifier;
    //private float countdown = 2f;
    public int enemyStartHealth; // Here to update info in UI Script, grabbed through global controller

    [Header("Rate of Damage")]
    //[SerializeField] float rate; 

    [Header("Enemy Varaibles")]
    public int enemyDamage; // Grab the damage from My Stats
    public int enemyHealth; // Grabing prefabed enemy health to modify for this specific enemy
    private GlobalController global; // Creating global variable

    void Awake() // Do this to set Enemy Count, and EnemyType
    {
        StaticVariables.masterEnemyCount += 1;
        myIdentifier = myStats.identifier;
    }


    void Start()
    {
        //rate = 0.1f;
        global = GlobalController.instance;
        global.currentEnemy = enemySelf;
        enemyHealth = myStats.vitality;
        enemyStartHealth = myStats.vitality;
        enemyDamage = myStats.damage;
    }

    public void Update()
    {
        UniqueBehavior(myIdentifier); 
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

        }
        if (identity == "Legionary")
        {
            global.starSpawnerFrameworkScript.LegionaryEffect();
        }
        if (identity == "Lumberjack")
        {
            
        }
        else
        {
            //Debug.LogError("Enemy type is null!");
        }
    }

    public void enemyDie() // Death
    {
        Destroy(this);
        global.enemySwitcherFrameworkScript.EnemySwitch();
    }

    public void EnemyDamaged(int _health) // Enemy is damaged, adjust numbers
    {
        StaticVariables.enemyCurrentHealth -= _health;
    }
}
