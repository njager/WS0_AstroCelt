using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Star : MonoBehaviour
{
    [Header("Star Attributes")]
    public bool starUsed = false;
    public Star starSelf;
    public Material normalColor;
    public Material usedColor; 


    private GlobalController global;

    void Start()
    {
        global = GlobalController.instance;

        starUsed = false;
        global.Star = starSelf;
        global.startingStarList.Add(this);
        global.ListCount++;
        Debug.Log("Star Added");
    }


    public void Selected()
    {

    }

    public void StarUsed() 
    {
        global.startingStarList.Remove(this);
        global.usedStarList.Add(this); 
    }

}
