using System.IO.IsolatedStorage;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [Header("Vitality")]
    public static int playerVitality;
    public static int startingPlayerVitality;
    [SerializeField] int _startingVitality = 400;

    [Header("Shield")]
    public static int shieldHealth;
    public static int startingShieldHealth;
    [SerializeField] int _startingShield = 0;

    [Header("Damage")]
    public static int playerDamage;
    public int startingPlayerDamage = 10; 

    [Header("Cosmic Energy")] 
    public static int playerCosmicEnergy;
    public static int startingPlayerCosmicEnergy;  
    [SerializeField] int _startingCosmicEnergy = 400;

    // UI Start Methods, by doing this I explicitly request and send back data

    public static int returnStartingVitality() // Not used
    {
        int _returnVitality = 400; 
        return _returnVitality;
    }

    public static int returnStartingCosmicEnergy() // Needed because race conditions for Start Methods
    {
        int _returnCE = 500;
        return _returnCE;
    }

    public static int returnStartingShieldHealth() // For Shields
    {
        int _returnShieldHealth = 0;
        return _returnShieldHealth;
    }

    public void Start()
    {
        startingPlayerVitality = _startingVitality;
        startingPlayerCosmicEnergy = _startingCosmicEnergy;
        playerVitality = startingPlayerVitality;
        playerDamage = startingPlayerDamage;
        playerCosmicEnergy = startingPlayerCosmicEnergy;
        shieldHealth = _startingShield; 

    }
}
