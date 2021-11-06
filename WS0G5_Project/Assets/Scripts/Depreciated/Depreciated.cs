using System.Collections;
using System.Collections.Generic;
using System.Linq; 
using UnityEngine;

public class Depreciated : MonoBehaviour
{
    // Need vars
    private GlobalController global;

    public void Start()
    {
        global = GlobalController.instance;
    }

    private string starTag;

    void OldRaycastCode()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse was clicked");
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            RaycastHit2D objectHit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (objectHit.collider != null)
            {
                if (objectHit.collider.tag == starTag)
                {
                    Debug.Log("Clicked on Star");

                }
            }
        }
    }

    public void drawLine(GameObject constellationLine, Vector3 initialPosition, Vector3 finalPosition) // Grabbed online, may be better 
    {
        var distance = 0f;
        Vector3 centerPos = (initialPosition + finalPosition) / 2f;

        constellationLine.transform.position = centerPos;

        Vector3 direction = finalPosition - initialPosition;
        direction = Vector3.Normalize(direction);
        constellationLine.transform.right = direction;

        distance = Vector3.Distance(initialPosition, finalPosition);

        Debug.DrawLine(initialPosition, finalPosition);

        constellationLine.GetComponent<RectTransform>().sizeDelta = new Vector3(distance, 40f);
    }

    // From Constellation Building 

    /*
        * 
        * Old Code that code maybe be needed in the future
       if(enumeratorTriggered == true)
       {
           TimerTrigger();
           DoubleDeleting(); 
       } */

    private float _timer = 0f;

    IEnumerator TimerTrigger() // Thought I needed to delete twice
    {
        _timer = _timer + 0.01f;
        yield return new WaitUntil(() => _timer > 3.0);
    }

    public void DoubleDeleting()
    {
        Debug.Log("Double Deleting");
        foreach (LineRendererScript lineRenderer in global.lineRendererList.ToList())
        {
            Destroy(lineRenderer.gameObject);
        }
        // enumeratorTriggered = false;
        _timer = 0f;
    }

    // chargeTime += Time.deltaTime;
            //if (chargeTime >= maxCharge)
            //{
                //chargeTime = 0;
                //global.currentEnemy.enemyAttacksPlayer(global.currentEnemy.enemyDamage);
            //}

    //Estimated turn count needed to defeat an enemy
    //
    //
    // In Awake(), _currentTurn, reference _currentTurn for multi-turn actions 

    // Use Fixed Update over update

    // Bring back the idea of confirmation button 

    // Turns for enemies need to lock out player, trigger bools, coroutine? Every end turn button

    // Use bools to invalidate turns

    //Space bar ends turn
    //Calculate area of the branches before adding their value
    //Line value is now the determiner of the constellation value 

    // Node idea,yes, how many nodes, how many branches can come off the node? Are these limited?
    // Polygons

    // All stars can only have two lines touching

    // Create a prefab called a node star, can the node be placed?

    //Change enemy to turnbased 
}
