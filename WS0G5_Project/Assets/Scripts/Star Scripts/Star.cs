using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class Star : MonoBehaviour
{
    [Header("Star Attributes")]
    public StarClass myStarClass; 
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

    void Awake()
    {
        myStarClass = global.starSpawnerFrameworkScript.baseStar;  
        global = GlobalController.instance;

        starUsed = false;
        global.Star = starSelf;
        global.startingStarList.Add(this);
        global.ListCount++;
        Debug.Log("Star Added");

        // rend = starGraphic.GetComponent<Renderer>();
        //startColor = rend.material.color;
        starPosition = starSelf.transform;
    }

    
    public void OnMouseDown()
    {
        Debug.Log("Clicked on Star");
        if (global.drawingScript.activeStarCounter == 0)
        {
            global.drawingScript.activeStarCounter = 1;
            global.starSpawnerFrameworkScript.starActive = 1;
            global.drawingScript.star1 = this;
            Debug.Log("Set activeStarCounter to 1");
            return;
        }
        if (global.drawingScript.activeStarCounter == 1)
        {
            global.drawingScript.star2 = this;
            global.drawingScript.drawLine();
            Debug.Log("Set activeStarCounter to 2");
            return;
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
            //rend.material.color = hoverColor;
        }
    }

    public void OnMouseExit()
    {
        //rend.material.color = startColor;
    }

    public void StarUsed() 
    {
        rend.material.color = usedColor;
        global.constellationBeingBuilt.Add(this);
        
    }

}
