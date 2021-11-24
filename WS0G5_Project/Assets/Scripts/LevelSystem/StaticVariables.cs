using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticVariables : MonoBehaviour
{
    /// <summary>
    /// A script to instance Static varaibles, aka giving them their first calls
    /// and allow them a "home" to use to be referenced for them outside of GlobalController
    ///
    /// I am intentionally keeping the PlayerStats static variables from this script 
    /// </summary>\
    ///

    // Private Varaibles
    private GlobalController global;

    [Header("Lines")]
    public static int lineCount;
    public static int starCount;
    public static int constellationDamageStarCount; // Use to limit to 1 action star in a constellation 
    public static int constellationHealthStarCount; // Use to limit to 1 action star in a constellation.

    [Header("Enemy Varaibles")]
    public int levelExpectedEnemyCount; // Can adjust in the editor 
    public static int masterEnemyCount;
    public static int enemyCurrentHealth;
    public static int enemyStartingHealth;
    public int startingCount = 0;
    public static int expectedEnemyCount; // By making it static, we could have an event where enemies spawn in to the pre-built level

    [Header("Level Stats")]
    public static int newStarSpawnGenerationCount; // Use this for score calculation if need be. 

    [Header("Functions")]
    public string placeholder;

    public int returnExpectedEnemyCount() // Use this to set the UI for Max
    {
        int returnLevelExpectedEnemyCount = levelExpectedEnemyCount; // Grabbing value from editor 
        return returnLevelExpectedEnemyCount; // Giving that value to UI start method. 
    }

    public int returnCurrentEnemyCount()
    {
        int _currentCount = masterEnemyCount;
        return _currentCount;
    }

    public int returnCurrentEnemyHealth()
    {
        int _returnEnemyHealth = enemyCurrentHealth;
        return _returnEnemyHealth;
    }

    public int returnStartEnemyHealth()
    {
        int _returnEnemyStartHealth = enemyStartingHealth;
        return _returnEnemyStartHealth;
    }

    public int returnLineCount() // Using this to set line id
    {
        int _temp = lineCount;
        return _temp; 
    }

    public int returnStarCount() // Using this to compare
    {
        int _temp = starCount;
        return _temp;
    }

    public void Awake()
    {
        lineCount = startingCount;
        expectedEnemyCount = levelExpectedEnemyCount;
        newStarSpawnGenerationCount = 0; // Does not count the initial generation
    }

    public void Start()
    {
        global = GlobalController.instance;
        //enemyStartingHealth = global.currentEnemy.enemyHealth;
        enemyCurrentHealth = enemyStartingHealth; 
    }
}
