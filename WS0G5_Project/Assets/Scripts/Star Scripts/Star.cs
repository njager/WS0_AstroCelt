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

    [Header("Stun Star")]

    //Global Setting
    private GlobalController global;

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
    }
    public void OnMouseDown()
    {
        if (global.playerScript.isPlayerTurn == true)
        {
            if (this == global.drawingScript.NodeStar)
            {
                if (global.drawingScript.nodeClickCount >= 1)
                {
                    global.drawingScript.star2 = this;
                    global.drawingScript.activeStarCounter = 1;
                    global.drawingScript.starCount = -1;
                    global.drawingScript.drawLine();
                }
                else
                {
                    global.drawingScript.nodeClickCount += 1;
                }
            }
            if (starFullyUsed == false)
            {
                Debug.Log("Clicked on Star");
                if (global.drawingScript.activeStarCounter == 0)
                {
                    if (global.drawingScript.starCount == 0)
                    {
                        global.drawingScript.star2 = this;
                        global.drawingScript.activeStarCounter = 1;
                        //Debug.Log("Set activeStarCounter to 1");
                        return;
                    }
                    if (global.drawingScript.starCount >= 0)
                    {
                        global.drawingScript.star2 = this;
                        global.drawingScript.activeStarCounter = 1;
                        global.drawingScript.drawLine();
                        //Debug.Log("Else Triggered");
                    }
                }
                if (global.drawingScript.activeStarCounter == 1)
                {
                    if (global.drawingScript.starCount >= 0)
                    {
                        if (global.drawingScript.star2 == this)
                        {
                            Debug.Log("Please click a different Star");
                            global.drawingScript.activeStarCounter = 1;
                            return;
                        }
                        if (global.drawingScript.starNext == this)
                        {
                            Debug.Log("Please click a different Star");
                            global.drawingScript.activeStarCounter = 1;
                            return;
                        }
                        else
                        {
                            global.drawingScript.star2 = this;
                            global.drawingScript.drawLine();
                            //Debug.Log("Set activeStarCounter to 2");
                            return;
                        }
                    }
                }
                if (global.drawingScript.activeStarCounter <= 1)
                {
                    Debug.Log("Reseting activeStarCounter to 0");
                    global.drawingScript.activeStarCounter = 0;
                }
            }
            else
            {
                Debug.Log("Star Used Up");
            }
        }
        else
        {
            Debug.Log("It's not your turn!"); 
        }
        
    }

    /*private void OnDrawGizmosSelected() // Doesn't work in play :(
    {
        if (this == global.drawingScript.starNext)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, 2.5f);
        }
    }*/

    public void OnMouseEnter()
    {
        rend.material.color = hoverColor;
    }

    public void OnMouseExit()
    {
        rend.material.color = startColor;
    }

    public void StarUsed()
    {
        rend.material.color = usedColor;
        startColor = usedColor;
        hoverColor = usedColor; 
        starFullyUsed = true;
        return; 
    }

    public void StunStarAbility()
    {
        if (myStarClass.starType == "StunStar")
        {
            
        }
    }

    public void ShieldStarAbility()
    {
        if (myStarClass.starType == "ShieldStar")
        {

        }
    }


    public void OnMouseDown2()
    {
        if (this == global.drawingScript.NodeStar)
        {
            if (global.drawingScript.nodeClickCount >= 1)
            {
                global.drawingScript.star2 = this;
                global.drawingScript.activeStarCounter = 1;
                global.drawingScript.starCount = -1;
                global.drawingScript.drawLine();
            }
            else
            {
                global.drawingScript.nodeClickCount += 1;
            }
        }
        if (starFullyUsed == false)
        {
            Debug.Log("Clicked on Star");
            if (global.drawingScript.activeStarCounter == 0)
            {
                if (global.drawingScript.starCount == 0)
                {
                    global.drawingScript.star2 = this;
                    global.drawingScript.activeStarCounter = 1;
                    //Debug.Log("Set activeStarCounter to 1");
                    return;
                }
                if (global.drawingScript.starCount >= 0)
                {
                    global.drawingScript.star2 = this;
                    global.drawingScript.activeStarCounter = 1;
                    global.drawingScript.drawLine();
                    //Debug.Log("Else Triggered");
                }
            }
            if (global.drawingScript.activeStarCounter == 1)
            {
                if (global.drawingScript.starCount >= 0)
                {
                    if (global.drawingScript.star2 == this)
                    {
                        Debug.Log("Please click a different Star");
                        global.drawingScript.activeStarCounter = 1;
                        return;
                    }
                    if (global.drawingScript.starNext == this)
                    {
                        Debug.Log("Please click a different Star");
                        global.drawingScript.activeStarCounter = 1;
                        return;
                    }
                    else
                    {
                        global.drawingScript.star2 = this;
                        global.drawingScript.drawLine();
                        //Debug.Log("Set activeStarCounter to 2");
                        return;
                    }
                }
            }
            if (global.drawingScript.activeStarCounter <= 1)
            {
                Debug.Log("Reseting activeStarCounter to 0");
                global.drawingScript.activeStarCounter = 0;
            }
        }
        else
        {
            Debug.Log("Star Used Up");
        }
    }

    ///
    /// Organize the enemies by challenge ratings, scouts not the last enemies. 
    ///

}
