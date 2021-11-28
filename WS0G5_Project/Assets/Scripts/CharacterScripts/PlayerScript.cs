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
    public bool isPlayerTurn; 

    void Start()
    {
        global = GlobalController.instance; 
        playerHealthLimit = _startingPlayerVitality;
        isPlayerTurn = true; 
    }

    public void Update()
    {
        if (isPlayerTurn == true)
        {
            global.playerTurnBar.SetActive(true);
            global.enemyTurnBar.SetActive(false);
        }
        if(global.playerShieldCount < 0)
        {
            global.playerShieldCount = 0;
        }
    }

    public void PlayerReset()
    {
        global.playerStats.Start(); 
    }

    public void playerDamaged(int damage)
    {
        if(global.playerShieldCount > 0)
        {
            int _check = damage - global.playerShieldCount;
            global.playerShieldCount -= damage;
            if(_check > 0)
            {
                PlayerStats.playerVitality -= _check;
            }
            global.m_SoundEffectDamage.Play();
            
        }
        
        else
        {
            PlayerStats.playerVitality -= damage;
            global.m_SoundEffectDamage.Play();
            //Debug.Log("Player Hit"); 
            showHealth = PlayerStats.playerVitality;
        }
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

    public void PlayerShields(int health)
    {
        if (global.playerShieldCount != 20)
        {
            global.playerShieldCount += health;
        }
        else
        {
            Debug.Log("Can't Shield, At Max Shielding!");
        }
    }
}
