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
    private Transform starPosition; 

    //Global Setting
    private GlobalController global;

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
        starPosition = starSelf.transform;
    }

    public void StarReset()
    {
        starUsed = false;
        global.drawingScript.activeStarCounter = 0;
        global.starSpawnerFrameworkScript.starActive = 0;
    }


   
    public void OnMouseDown()
    {
        Debug.Log("Clicked on Star");
        global.activeStarList.Add(this);
        if (global.drawingScript.activeStarCounter == 0)
        {
            global.drawingScript.activeStarCounter = 1;
            global.starSpawnerFrameworkScript.starActive = 1;
        }
        if (global.drawingScript.activeStarCounter == 1)
        {
            global.drawingScript.activeStarCounter = 2;
            global.starSpawnerFrameworkScript.starActive = 2;
            global.drawingScript.drawLine(); 
        }
        if (global.drawingScript.activeStarCounter == 2)
        {
            StarReset(); 
        }

        //if (EventSystem.current.IsPointerOverGameObject())
        //{
        //return;
        //}

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
