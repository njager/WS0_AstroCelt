using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private int playerHealthLimit;
    private GlobalController global; // Global Controller reference

    void Start()
    {
        global = GlobalController.instance; 
        playerHealthLimit = PlayerStats.playerVitality;
    }

    public void PlayerReset()
    {
        global.playerStats.Start(); 
    }

    public void playerDamaged()
    {
        PlayerStats.playerVitality -= 1; 
    }

    public void PlayerHealed()
    {

    }
}
