using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ResetBehavior : MonoBehaviour
{
    private GlobalController global; 
    void Start()
    {
        global = GlobalController.instance; 
    }

    // Update is called once per frame
    public void GameReset()
    {
        global.starSpawnerFrameworkScript.FrameworkReset();
        foreach (LineRendererScript line in global.lineRendererResetList.ToList())
        {

        }
    }
}
