using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class Star : MonoBehaviour
{
    [Header("Star Attributes")]
    public bool starUsed = false;
    public Star starSelf;
    public Material normalColor;
    public Material usedColor;
    public Color hoverColor;
    public Color usedColor2; 

    // Private varaibles 
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

    public void StarReset()
    {
        starUsed = false; 
    }

    public void Selected()
    {

    }

    public void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }
    }

    public Vector3 lineStartingPoint()
    {
        return transform.position;
    }

    public void OnMouseEnter()
    {
        
    }

    public void OnMouseExit()
    {
        
    }

    public void StarUsed() 
    {
        global.startingStarList.Remove(this);
        global.usedStarList.Add(this); 
    }

}
