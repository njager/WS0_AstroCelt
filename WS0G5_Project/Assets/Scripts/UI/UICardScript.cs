using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UICardScript : MonoBehaviour
{
    //private variables
    //public EventTrigger dragger;
    //bool dragging = EventSystem.dragging

    //public variables


    // Start is called before the first frame update
    void Start()
    {
        //dragger = GetComponent<EventTrigger>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (dragger.dragging)
        {
            transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }*/
    }

    //detect when the card enters a slot trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Entering the slot!");
    }

    //detect when the card exits a slot trigger
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Exiting the slot!");
    }

}
