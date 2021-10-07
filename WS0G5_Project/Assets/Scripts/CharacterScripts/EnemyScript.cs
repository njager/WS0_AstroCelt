using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [Header("Enemy Attributes")]
    public EnemyStats myStats;
    public GameObject enemyGraphic;
    public EnemyScript enemySelf; 

    private int enemyHealth; // Grabing prefabed enemy health to modify for this specific enemy
    // 18
    private GlobalController global; // Creating global variable
    private int enemyCount; 


    void Start()
    {
        enemyCount = 0; 
        global = GlobalController.instance;
        global.currentEnemy = this;
        enemyHealth = myStats.vitality; 
    }

    void Update()
    {
        enemyTimer(); 
    }

    public void enemyTimer()
    {
        return; 
    }
   
    public void enemyAttacksPlayer(int damage)
    {
        global.playerScript.playerDamaged(damage); 
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
            global.Win(); 
        }
    }
}
