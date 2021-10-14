using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseBehavior : MonoBehaviour
{
    private GlobalController global;

    // Start is called before the first frame update
    void Start()
    {
        global = GlobalController.instance; 
    }

    void Update()
    {
        if(PlayerStats.playerVitality < 0)
        {
            global.Lose(); 
        }
    }
}
