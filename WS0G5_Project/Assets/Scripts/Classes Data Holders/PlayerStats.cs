using System.IO.IsolatedStorage;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    // Vitality
    public static float playerVitality;
    public float startingPlayerVitality = 400f; 

    // Damage
    public static int playerDamage;
    public int startingPlayerDamage = 10; 

    // Cosmic Energy 
    public static int playerCosmicEnergy;
    public int startingPlayerCosmicEnergy = 500; 

    public void Start()
    {
        playerVitality = startingPlayerVitality;
        playerDamage = startingPlayerDamage;
        playerCosmicEnergy = startingPlayerCosmicEnergy; 
    }
}
