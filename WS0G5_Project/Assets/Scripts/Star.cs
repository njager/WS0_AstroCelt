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
    public Color hoverColor;
    public Color usedColor;
    public Vector3 positionOffset;
    public GameObject starGraphic; 

    //Global Setting
    GlobalController global;

    // Private Variables
    private Renderer rend;
    private Color startColor; 

    void Start()
    {
        global = GlobalController.instance;

        starUsed = false;
        global.Star = starSelf;
        global.startingStarList.Add(this);
        global.ListCount++;
        Debug.Log("Star Added");

        rend = starGraphic.GetComponent<Renderer>();
        startColor = rend.material.color; 
    }

    public void StarReset()
    {
        starUsed = false; 
    }

   
    public void OnClick()
    {
        //if (EventSystem.current.IsPointerOverGameObject())
        //{
            //return;
        //}

        Debug.Log("Clicked on Star");
        global.activeStarList.Add(this);
    }

    public Vector3 lineStartingPoint()
    {
        return transform.position + positionOffset;
    }

    public void OnMouseEnter()
    {
        if (global.starWasSelected)
        {
            rend.material.color = hoverColor;
        }
    }

    public void OnMouseExit()
    {
        rend.material.color = startColor;
    }

    public void StarUsed() 
    {
        global.startingStarList.Remove(this);
        global.usedStarList.Add(this); 
    }

}
