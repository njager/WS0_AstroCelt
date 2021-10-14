using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public GameObject playerSelf; 

    private int playerHealthLimit;
    private int _startingPlayerVitality = PlayerStats.startingPlayerVitality;
    public int showHealth; // I want to see health in inspector 
    private GlobalController global; // Global Controller reference

    void Start()
    {
        global = GlobalController.instance; 
        playerHealthLimit = _startingPlayerVitality;
    }

    public void PlayerReset()
    {
        global.playerStats.Start(); 
    }

    public void playerDamaged(int damage)
    {
        PlayerStats.playerVitality -= damage;
        //Debug.Log("Player Hit"); 
        showHealth = PlayerStats.playerVitality; 
    }

    public void PlayerHealed(int health)
    {
        if(PlayerStats.playerVitality != playerHealthLimit)
        {
            PlayerStats.playerVitality += health; 
        }
        else
        {
            Debug.Log("Can't Heal, At Max Health!"); 
        }
    }
}
