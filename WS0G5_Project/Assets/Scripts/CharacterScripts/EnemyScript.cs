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
    private float countdown = 2f;

    [Header("Rate of Damage")]
    [SerializeField] float rate; 

    [Header("Enemy Varaibles")]
    public int enemyDamage; // Grab the damage from My Stats
    public int enemyHealth; // Grabing prefabed enemy health to modify for this specific enemy
    private GlobalController global; // Creating global variable
   
    void Start()
    {
        rate = 0.1f; 
        EnemyStats.enemyCount += 1; 
        global = GlobalController.instance;
        global.currentEnemy = enemySelf;
        enemyHealth = myStats.vitality;
        enemyDamage = myStats.damage;
    }

    void Update()
    {
        if (countdown <= 0f)
        {
            StartCoroutine(enemyTimer());
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

    }
   
    public void enemyAttacksPlayer(int damage)
    {
        global.playerScript.playerDamaged(damage);
        Debug.Log("EnemyAttacks"); 
    }

    public void enemyDie()
    {
        Destroy(this); 
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
