using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using CodeMonkey.Utils;

public class UIController : MonoBehaviour
{
    //public variables
    //[Header("Public Variables")]
    //public static Transform pfPopup;

    //private variables
    [Header("Variables")]
    [SerializeField] int enemyCount;
    [SerializeField] int enemyMaxCount;
    [SerializeField] float timer;
    [SerializeField] int _ceCount;
    [SerializeField] int _playerHealth;
    [SerializeField] int _playerMaxHealth;
    [SerializeField] int _enemyHealth;
    [SerializeField] int enemyMaxHealth;
    [SerializeField] float chargeTime;
    [SerializeField] float maxCharge;
    //private float spawnTimer = 1f;
    private GlobalController global;

    //UI variables
    [Header("UI Element Slots")]
    [SerializeField] TextMeshProUGUI ceCountText;
    [SerializeField] TextMeshProUGUI enemyCountText;
    [SerializeField] TextMeshProUGUI playerHealthText;
    [SerializeField] TextMeshProUGUI enemyHealthText;
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] Image playerHealthBar;
    [SerializeField] Image enemyHealthBar;
    [SerializeField] Image enemyChargeBar;


    // Start is called before the first frame update
    void Start()
    {
        global = GlobalController.instance;
        
        //Popup.Create(Vector3.zero, 5; // Jager Test Line


        // Grabbing Static Variables First
        enemyCount = StaticVariables.masterEnemyCount;
        _ceCount = PlayerStats.startingPlayerCosmicEnergy;
        _enemyHealth = global.currentEnemy.enemyHealth;
        _playerMaxHealth = PlayerStats.startingPlayerVitality;
        enemyMaxHealth = global.currentEnemy.enemyStartHealth;
        enemyMaxCount = global.staticVariablesReference.returnExpectedEnemyCount();

        //Set up the text
        SetText();
    }

    // Update is called once per frame
    void Update()
    {
        //Update Variables
        UpdateUIVariables();

        //timer code
        float t = Time.timeSinceLevelLoad; // time since scene loaded
        int seconds = (int)(t % 60); // return the remainder of the seconds divide by 60 as an int
        t /= 60; // divide current time y 60 to get minutes
        int minutes = (int)(t % 60); //return the remainder of the minutes divide by 60 as an int
        timerText.text = string.Format("{0}:{1}", minutes.ToString("00"), seconds.ToString("00"));

        //set the charge timer and reset
        chargeTime += Time.deltaTime;
        if (chargeTime >= maxCharge)
        {
            chargeTime = 0;
            global.currentEnemy.enemyAttacksPlayer(global.currentEnemy.enemyDamage); 
        }

        //check type of output
        bool isDamage = Random.Range(0, 100) < 60;

        //cycle popup spawning
        //spawnTimer -= Time.deltaTime;
        //if (spawnTimer < 0)
        //{
            // Popup.Create(new Vector3(-100, 0, 1), 1, isDamage); 
            //spawnTimer = 1f;
        //}

        //update the text
        SetText();

        //test popup
        /*if (Input.GetKeyDown(KeyCode.F))
        {
            Popup.Create(new Vector3(-500, 0, 0), 3);
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            Popup.Create(new Vector3(0, 5, 0), 7);
        }*/
        // if (Input.GetMouseButtonDown(0))
        {
            // Popup.Create(UtilsClass.GetMouseWorldPosition(), 9, isDamage);

        }
    }

    void UpdateUIVariables() // Trying to keep Update Clutter down
    {
        enemyCount = StaticVariables.masterEnemyCount;
        _ceCount = PlayerStats.startingPlayerCosmicEnergy;
        _enemyHealth = global.currentEnemy.enemyHealth;
        _playerMaxHealth = PlayerStats.startingPlayerVitality;
        enemyMaxHealth = global.currentEnemy.enemyStartHealth;
        enemyMaxCount = global.staticVariablesReference.returnExpectedEnemyCount();
        return; 
    }

    //sets the text objects
    void SetText()
    {
        enemyCountText.text = enemyCount.ToString() + "/" + enemyMaxCount.ToString();
        ceCountText.text = _ceCount.ToString();
        playerHealthText.text = _playerHealth.ToString() + "/" + _playerMaxHealth.ToString();
        enemyHealthText.text = _enemyHealth.ToString() + "/" + enemyMaxHealth.ToString();

        //update health bars
        playerHealthBar.fillAmount = (float)_playerHealth / (float)_playerMaxHealth;
        enemyHealthBar.fillAmount = (float)_enemyHealth / (float)enemyMaxHealth;

        //update charge bar
        enemyChargeBar.fillAmount = (float)chargeTime / (float)maxCharge;
    }

    //function for making new stars
    public void NewStarsButton()
    {
        Debug.Log("You made some new stars, nice!");
    }
}
