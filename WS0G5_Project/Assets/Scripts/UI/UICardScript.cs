using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UICardScript : MonoBehaviour
{
    //private variables
    //public EventTrigger dragger;
    //bool dragging = EventSystem.dragging
    GameObject currentCard;
    
    //public variables
    public bool isDragging;
    public bool isDamage;
    public bool isHeal;
    public bool isShield;
    public bool inStarSlot1;
    public bool inStarSlot2;

    // Start is called before the first frame update
    void Start()
    {
        //currentCard = GetComponent<GameObject>();
        //dragger = GetComponent<EventTrigger>();
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
        if (Input.GetMouseButtonDown(0))
        {
            isDragging = true;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
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
