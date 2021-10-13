using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    // Commented out my own timer code but left it in just in case 
    [Header("Enemy Attributes")]
    public EnemyStats myStats;
    public GameObject enemyGameObject;
    public EnemyScript enemySelf;
    public float timeBetweenAttacks = 2f;
    //private float countdown = 2f;
    public int enemyStartHealth; // Here to update info in UI Script, grabbed through global controller

    [Header("Rate of Damage")]
    //[SerializeField] float rate; 

    [Header("Enemy Varaibles")]
    public int enemyDamage; // Grab the damage from My Stats
    public int enemyHealth; // Grabing prefabed enemy health to modify for this specific enemy
    private GlobalController global; // Creating global variable

    void Awake() // Do this to set Enemy Count
    {
        StaticVariables.masterEnemyCount += 1;
    }

    void Start()
    {
        //rate = 0.1f; 
        global = GlobalController.instance;
        global.currentEnemy = enemySelf;
        enemyStartHealth = myStats.vitality;
        enemyHealth = myStats.vitality;
        enemyDamage = myStats.damage;
    }

    public void Update()
    {
       
    }

    public int returnCurrentEnemyHealth()
    {
        int _returnEnemyHealth = enemyHealth;
        return _returnEnemyHealth; 
    }

    public void ResetBehavior() // Method of what to do in terms of reset/enemy switching 
    {
        Destroy(this);
    }

    public void OnDestroy() // Just for our purposes 
    {
        Debug.Log("Deleted Enemy Successfully");
    }

    /*void Update()
    {
        if (countdown <= 0f)
        {
            //StartCoroutine(enemyTimer());
            countdown = timeBetweenAttacks;
            return;
        }

        countdown -= Time.deltaTime; // Timer goes down according to update

        countdown = Mathf.Clamp(countdown, 0f, Mathf.Infinity);
    }

    IEnumerator enemyTimer()
    {
        enemyAttacksPlayer(enemyDamage);
        yield return new WaitForSeconds(1f / rate);

    }*/
   
    public void enemyAttacksPlayer(int damage)
    {
        global.playerScript.playerDamaged(damage);
        Debug.Log("EnemyAttacks"); 
    }

    public void enemyDie()
    {
        Destroy(this);
        global.enemySwitcherFrameworkScript.EnemySwitch();
    }

    public void EnemyDamaged(int health)
    {
        enemyHealth -= health; 
        if(enemyHealth <= 0)
        {
            enemyDie();
            global.Win(); // Remove when there is multiple enemies
        }
    }
}
