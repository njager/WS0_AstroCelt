using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class UICardScript : MonoBehaviour
{
    //private variables
    //public EventTrigger dragger;
    //bool dragging = EventSystem.dragging
    GameObject currentCard;

    [Header("Bools")]
    [SerializeField] bool isDragging;
    [SerializeField] bool isDamage;
    [SerializeField] bool isHeal;
    [SerializeField] bool isShield;
    [SerializeField] bool inStarSlot1;
    [SerializeField] bool inStarSlot2;

    //public variables
    public int damageStarLoadCount;
    public int healStarLoadCount;

    // Start is called before the first frame update
    void Start()
    {
        //currentCard = GetComponent<GameObject>();
        //dragger = GetComponent<EventTrigger>();

        //check tag of current card
        if(this.tag == "DamageCard")
        {
            isDamage = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        /*if (dragger.dragging)
        {
            transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }*/

        //if mouse button has been clicked and is held down then dragging
        //this is techincal debt because this does it any time mouse is clicked down, not just on card
        if (Input.GetMouseButtonDown(0))
        {
            isDragging = true;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
        }

        //check if card is no longer dragging to see if it's in a star slot
        if (!isDragging)
        {
            if (inStarSlot1)
            {
                if (isDamage)
                {
                    damageStarLoadCount++;
                }
            }
        }
        if (isDragging)
        {
            damageStarLoadCount = 0;
        }

    }
        //detect when the card enters a slot trigger
        private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Entering the slot!");
        if (collision.CompareTag("StarSlot1"))
        {
            inStarSlot1 = true;
        }
    }

    //detect when the card exits a slot trigger
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Exiting the slot!");
        if (inStarSlot1)
        {
            inStarSlot1 = false;
        }
    }

}
