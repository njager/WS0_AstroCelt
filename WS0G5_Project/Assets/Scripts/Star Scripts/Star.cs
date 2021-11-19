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
    public GameObject starSelf;
    public GameObject starGraphicSelf; 
    public Color hoverColor;
    public Color usedColor;
    public Vector3 positionOffset;
    public GameObject starGraphic;
    [SerializeField] int myCount;

    //Global Setting
    private GlobalController global;

    // Private Variables
    private SpriteRenderer rend;
    private Color startColor;

    public void Start()
    {
        global = GlobalController.instance;

        global.ListCount++;
        Debug.Log("Star Added");

        rend = starGraphicSelf.GetComponent<SpriteRenderer>();
        startColor = rend.material.color;
        myCount = IncreaseStarCount();
    }

    public void OnMouseDown()
    {
        if (global.constellationBuilding.hasThePlayerDrawnForTurn == false) // If the player has already drawn for turn, do nothing
        {
            if (global.playerScript.isPlayerTurn == true) // Check if it's the player's turns
            {
                if (this == global.drawingScript.NodeStar) // Check to see if it's the node
                {
                    if (global.drawingScript.nodeClickCount >= 1) // If a node has been clicked a second time trigger the behavior
                    {
                        global.drawingScript.star2 = this;
                        global.drawingScript.activeStarCounter = 1;
                        global.drawingScript.starCount = -1;
                        global.drawingScript.drawLine();
                    }
                    else // If a node hasn't been clicked
                    {
                        global.drawingScript.nodeClickCount += 1;
                    }
                }
                if (starUsed == false) // See if the star has been used in the constellations thus far
                {
                    Debug.Log("Clicked on Star");
                    if (global.drawingScript.activeStarCounter == 0) // Regular star drawing
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
        else
        {
            Debug.Log("You've already drawn for the turn!"); 
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

    public void StarUsed()
    {
        if(myStarClass.starType == "NodeStar")
        {
            global.drawingScript.nodeClickCount = 1;
            global.drawingScript.activeStarCounter = 1;
            global.constellationBeingBuilt.Add(this); 
            return;
        }
        else
        {
            rend.material.color = usedColor;
            startColor = usedColor;
            hoverColor = usedColor;
            starUsed = true;
            return;
        }
    }

    public int IncreaseStarCount()
    {
        StaticVariables.starCount += 1;
        int _TempCount = global.staticVariablesReference.returnStarCount();
        return _TempCount;
    }

    /*void OnTriggerEnter(Collider col) // Here it detects the other gameObject
    {
        GameObject other = col.gameObject; // Col GameObject 
        if (myStarClass.starType != "NodeStar")
        {
            if (other != this.gameObject)
            {
                if (other.GetComponent<LineRenderer>() == null)
                    {
                    if (myCount < other.GetComponent<Star>().myCount)
                    {
                        other.SetActive(false);
                        Debug.Log("Destroying Other Star");
                        return;
                    }
                    else
                    {
                        Debug.Log("Destroying Self");
                        gameObject.SetActive(false);
                        return;
                    }
                }
            }
        }
        else
        {
            if (other != gameObject)
            {
                other.SetActive(false);
                Debug.Log("Destroying Other Star");
                return;
            }
        }
        
        if (other.CompareTag("Obstacle"))
        {
            if(myStarClass.starType == "NodeStar")
            {
                global.starSpawnerFrameworkScript.obstacleDeletedInGeneration +=1;
                Destroy(other);
                Debug.Log("Obstacle Hit Node Star");
            }
            else
            {
                if (myStarClass.starType == "HealthStar")
                {
                    global.starSpawnerFrameworkScript.healthStarDeletedInGeneration += 1;
                }
                if (myStarClass.starType == "DamageStar")
                {
                    global.starSpawnerFrameworkScript.damageStarDeletedInGeneration += 1;
                }
                Debug.Log("Hit obstacle in generation");
                gameObject.SetActive(false);
            }
        }
        else
        {
            return; 
        }
    }*/

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

    ///
    /// Organize the enemies by challenge ratings, scouts not the last enemies. 
    ///

}
