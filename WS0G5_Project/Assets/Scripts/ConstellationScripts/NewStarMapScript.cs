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
    [SerializeField] float chargeTime;
    [SerializeField] float maxCharge;
    [SerializeField] Image enemyChargeBar;

    void Start()
    {
        global = GlobalController.instance;
        loadBar.SetActive(false);
        loadBarBool = false;
        ResetBar();
    }

    void ResetBar()
    {
        maxCharge = 5f;
        chargeTime = 0; 
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

        enemyChargeBar.fillAmount = (float)chargeTime / (float)maxCharge;
    }

    public void NewStars() // Specific function to give tto button, where all helperm fucntions are gathered
    {
        LoadingScreen(true); 
        Debug.Log("Loading in New Stars");
        ChangingStarMap(); 
    }

    public void LoadingScreen(bool state) // Use a bool toggler for the loading bar functionality 
    {
        // First Reset Variable
        loadBarBool = state;
        loadBar.SetActive(true); // Then put into scene
    }

    public void ChangingStarMap() // Here's where we trigger the functions in other scripts as needed. 
    {
        global.starSpawnerFrameworkScript.NewStarMap(); 
    }
}
