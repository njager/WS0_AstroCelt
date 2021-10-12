using System.IO.IsolatedStorage;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [Header("Vitality")]
    public static int playerVitality;
    public int startingPlayerVitality = 400; 

    [Header("Damage")]
    public static int playerDamage;
    public int startingPlayerDamage = 10; 

    [Header("Cosmic Energy")] 
    public static int playerCosmicEnergy;
    public int startingPlayerCosmicEnergy = 500;

    // UI Start Methods, by doing this I explicitly request and send back data

    public int returnStartingVitality() // Needed because race conditions for Start Methods
    {
        int _returnVitality = startingPlayerVitality; 
        return _returnVitality;
    }

    public int returnStartingCosmicEnergy() // Needed because race conditions for Start Methods
    {
        int _returnCE = startingPlayerCosmicEnergy;
        return _returnCE;
    }

    public void Start()
    {
        playerVitality = startingPlayerVitality;
        playerDamage = startingPlayerDamage;
        playerCosmicEnergy = startingPlayerCosmicEnergy; 
    }
}
