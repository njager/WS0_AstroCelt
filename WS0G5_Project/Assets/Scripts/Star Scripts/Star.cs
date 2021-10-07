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
    public bool starFullyUsed = false; 
    public GameObject starSelf;
    public GameObject starGraphicSelf; 
    public Color hoverColor;
    public Color usedColor;
    public Vector3 positionOffset;
    public GameObject starGraphic;

    //Global Setting
    private GlobalController global;
    private Transform starPosition; 

    // Private Variables
    private SpriteRenderer rend;
    private Color startColor;

    public void Start()
    {
        global = GlobalController.instance;

        starUsed = false;
        global.ListCount++;
        Debug.Log("Star Added");

        rend = starGraphicSelf.GetComponent<SpriteRenderer>();
        startColor = rend.material.color;
        starPosition = starSelf.transform;
    }

    
    public void OnMouseDown()
    {
        if (starFullyUsed == false)
        {
            Debug.Log("Clicked on Star");
            if (global.drawingScript.activeStarCounter == 0)
            {
                global.drawingScript.startingStar = this;
                global.drawingScript.activeStarCounter = 1;
                global.drawingScript.star1 = this;
                Debug.Log("Set activeStarCounter to 1");
                return;
            }
            if (global.drawingScript.activeStarCounter == 1)
            {
                if (global.drawingScript.star1 == this)
                {
                    Debug.Log("Click a different Star");
                    global.drawingScript.activeStarCounter = 1;
                    return;
                }
                global.drawingScript.star2 = this;
                global.drawingScript.drawLine();
                Debug.Log("Set activeStarCounter to 2");
                return;
            }
        }
        else
        {
            Debug.Log("Star Used Up");
        }
    }

    public void OnMouseEnter()
    {
        rend.material.color = hoverColor;
    }

    public void OnMouseExit()
    {
        rend.material.color = startColor;
    }

    public void StarTempUsed() 
    {
        global.constellationBeingBuilt.Add(this);
        
    }

    public void StarUsed()
    {
        rend.material.color = usedColor;
        starFullyUsed = true;
        return; 
    }

}
