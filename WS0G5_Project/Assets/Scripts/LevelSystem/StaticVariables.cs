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
    public static int enemyCurrentHealth1;
    public static int enemyStartingHealth1;
    public static int enemyCurrentHealth2;
    public static int enemyStartingHealth2;
    public static int enemyCurrentHealth3;
    public static int enemyStartingHealth3;
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

    public int returnCurrentEnemyHealth1()
    {
        int _returnEnemyHealth = enemyCurrentHealth1;
        return _returnEnemyHealth;
    }

    public int returnStartEnemyHealth1()
    {
        int _returnEnemyStartHealth = enemyStartingHealth1;
        return _returnEnemyStartHealth;
    }

    public int returnCurrentEnemyHealth2()
    {
        int _returnEnemyHealth = enemyCurrentHealth2;
        return _returnEnemyHealth;
    }

    public int returnStartEnemyHealth2()
    {
        int _returnEnemyStartHealth = enemyStartingHealth2;
        return _returnEnemyStartHealth;
    }

    public int returnCurrentEnemyHealth3()
    {
        int _returnEnemyHealth = enemyCurrentHealth3;
        return _returnEnemyHealth;
    }

    public int returnStartEnemyHealth3()
    {
        int _returnEnemyStartHealth = enemyStartingHealth3;
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
        enemyStartingHealth1 = global.enemy1.enemyHealth;
        enemyCurrentHealth1 = global.enemy1.enemyHealth;
        enemyStartingHealth2 = global.enemy2.enemyHealth;
        enemyCurrentHealth2 = global.enemy2.enemyHealth;
        enemyStartingHealth3 = global.enemy3.enemyHealth;
        enemyCurrentHealth3 = global.enemy3.enemyHealth;
    }
}
