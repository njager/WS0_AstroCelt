using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICardScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
