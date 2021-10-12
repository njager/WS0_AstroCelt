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

    public int levelExpectedEnemyCount; // Can adjust in the editor 

    public static int masterEnemyCount;

    public static int expectedEnemyCount; // By making it static, we could have an event where enemies spawn in to the pre-built level

    public int returnExpectedEnemyCount()
    {
        int returnLevelExpectedEnemyCount = levelExpectedEnemyCount; // Grabbing value from edtor 
        return returnLevelExpectedEnemyCount; // Giving that value to UI start method. 
    }

    public void Start()
    {
        masterEnemyCount = 0; // Expected Start value for stating script, to be edited by enemy instance
        expectedEnemyCount = levelExpectedEnemyCount;

    }
}
