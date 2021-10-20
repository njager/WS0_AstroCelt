using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro; 

public class NewStarMapScript : MonoBehaviour
{
    private GlobalController global;
    public GameObject loadBar;
    private bool loadBarBool; 

    void Start()
    {
        global = GlobalController.instance;
        loadBar.SetActive(false);
        loadBarBool = false; 
    }

    public void Update()
    {
        if (loadBarBool == true)
        {

        }
        else
        {
            return; 
        }
    }

    public void NewStars()
    {
        LoadingScreen(); 
        Debug.Log("Loading in New Stars");
        ChangingStarMap(); 
    }

    public void LoadingScreen()
    {
        // First Reset Variables


        loadBar.SetActive(true); // Then put into scene
    }

    public void ChangingStarMap() 
    {
        global.starSpawnerFrameworkScript.NewStarMap(); 
    }
}
