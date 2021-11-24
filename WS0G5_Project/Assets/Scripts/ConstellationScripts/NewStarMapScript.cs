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
    public bool newStarsClicked;

    void Start()
    {
        global = GlobalController.instance;
        loadBar.SetActive(false);
        loadBarBool = false;
        ResetBar();
        newStarsClicked = false; 
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
            StartCoroutine(LoadingScreen(false));
        }
        else
        {
            loadBar.SetActive(false);
        }

        enemyChargeBar.fillAmount = (float)chargeTime / (float)maxCharge;
    }

    public void NewStars() // Specific function to give tto button, where all helperm fucntions are gathered
    {
        StartCoroutine(LoadingScreen(true)); 
        Debug.Log("Loading in New Stars");
        ChangingStarMap();
        //if (global.currentEnemy.myIdentifier == "Legionary") // Allows the legionary to spawn a new barrier with the new stars button 
        {
         //   global.currentEnemy.legionaryEffectCounter = 0;
        }
    }

    public void NewStars2() // For the purposes of the prototype
    {
        global.starSpawnerFrameworkScript.starSpawnCount = 0;
        global.starSpawnerFrameworkScript.ClearStars();
        global.drawingScript.nodeStar2.gameObject.SetActive(true);
        global.drawingScript.star1 = global.drawingScript.nodeStar2;
        global.drawingScript.NodeStar.gameObject.SetActive(false); 
        //global.starSpawnerFrameworkScript.HandBuiltMap2(global.starSpawnerFrameworkScript.baseStar);
        //global.starSpawnerFrameworkScript.HandBuiltMap2(global.starSpawnerFrameworkScript.actionHealthStar);
        //global.starSpawnerFrameworkScript.HandBuiltMap2(global.starSpawnerFrameworkScript.actionDamageStar);
    }

    public void NewStarsPlayTest()
    {
        newStarsClicked = true; 
        global.starSpawnerFrameworkScript.HardcodedNewStarsSpawn(); 
    }

    public IEnumerator LoadingScreen(bool state) // Use a bool toggler for the loading bar functionality 
    {
        // First Reset Variable
        loadBarBool = state;
        loadBar.SetActive(true); // Then put into scene

        // Loading Screen timer and behavior 


        loadBarBool = false; 
        yield return new WaitUntil(() => loadBarBool == false); 
    }

    public void ChangingStarMap() // Here's where we trigger the functions in other scripts as needed. 
    {
        global.starSpawnerFrameworkScript.NewStarMap(); 
    }
}
