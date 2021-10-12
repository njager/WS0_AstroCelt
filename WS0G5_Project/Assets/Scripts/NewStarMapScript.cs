using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewStarMapScript : MonoBehaviour
{
    private GlobalController global;

    void Start()
    {
        global = GlobalController.instance; 
    }

    public void NewStars()
    {
        Debug.Log("Loading in New Stars"); 
    }
}
