using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using CodeMonkey.Utils;
using DG.Tweening;

public class UIController : MonoBehaviour
{
    //public variables
    //[Header("Public Variables")]
    //public static Transform pfPopup;

    //private variables
    [Header("Variables")]
    [SerializeField] int _enemyCount;
    [SerializeField] int _enemyMaxCount;
    [SerializeField] float timer;
    [SerializeField] int _ceCount;
    [SerializeField] int _playerHealth;
    [SerializeField] int _playerMaxHealth;
    [SerializeField] int _enemyHealth;
    [SerializeField] int _enemyMaxHealth;
    public GameObject selector; 
    //[SerializeField] float chargeTime;
    //[SerializeField] float maxCharge;
    private float spawnTimer = 1f;
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
    //[SerializeField] Image enemyChargeBar;

    [Header("Enemy 2")]
    [SerializeField] TextMeshProUGUI enemyHealthText2;
    [SerializeField] Image enemyHealthBar2;
    [SerializeField] int _enemyHealth2;
    [SerializeField] int _enemyMaxHealth2;

    [Header("Enemy 3")]
    [SerializeField] TextMeshProUGUI enemyHealthText3;
    [SerializeField] Image enemyHealthBar3;
    [SerializeField] int _enemyHealth3;
    [SerializeField] int _enemyMaxHealth3;

    public bool isEnemyDead;  

    // Red is DD6666
    // Health is SECC71


    // Start is called before the first frame update
    void Start()
    {
        global = GlobalController.instance;
        
        // Grabbing Static Variables First
        _enemyCount = StaticVariables.masterEnemyCount;
        _ceCount = PlayerStats.startingPlayerCosmicEnergy;
        //_enemyHealth = global.currentEnemy.enemyHealth;
        _enemyHealth2 = global.enemy2.enemyHealth;
        _enemyHealth3 = global.enemy3.enemyHealth;
        _playerHealth = PlayerStats.playerVitality;
        _playerMaxHealth = PlayerStats.startingPlayerVitality;
        //_enemyMaxHealth = global.currentEnemy.enemyStartHealth;
        _enemyMaxHealth2 = global.enemy2.enemyHealth;
        _enemyMaxHealth3 = global.enemy3.enemyHealth;
        _enemyMaxCount = global.staticVariablesReference.returnExpectedEnemyCount();
        //maxCharge = global.currentEnemy.turnsBetweenAttacks;

        //Set up the text
        SetText();

        isEnemyDead = false; 

        DOTween.Init();
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
        timerText.text = string.Format("Turn: {0}", global.turnManagerScript.playerTurnCount.ToString());

        //set the charge timer and reset
        if(isEnemyDead == false)
        {
            // Enemy Attacking
        }
        

        //check type of output
        bool isDamage = Random.Range(0, 100) < 60;

       
        SetText();

        spawnTimer -= Time.deltaTime;
        if (spawnTimer < 0)
        {
            Popup.Create(new Vector3(-100, 0, 1), 1, 0);
            spawnTimer = 1f;
        }
    }

    void UpdateUIVariables() // Trying to keep Update Clutter down
    {
        _enemyCount = global.staticVariablesReference.returnCurrentEnemyCount();
        _ceCount = PlayerStats.startingPlayerCosmicEnergy;
        _enemyHealth = global.staticVariablesReference.returnCurrentEnemyHealth();
        _enemyHealth2 = global.enemy2.enemyHealth;
        _enemyHealth3 = global.enemy3.enemyHealth;
        _playerHealth = PlayerStats.playerVitality;
        _playerMaxHealth = PlayerStats.startingPlayerVitality;
        _enemyMaxHealth = global.staticVariablesReference.returnStartEnemyHealth();
        _enemyMaxCount = global.staticVariablesReference.returnExpectedEnemyCount();
        return; 
    }

    //sets the text objects
    void SetText()
    {
        enemyCountText.text = _enemyCount.ToString() + "/" + _enemyMaxCount.ToString();
        ceCountText.text = _ceCount.ToString();
        playerHealthText.text = _playerHealth.ToString() + "/" + _playerMaxHealth.ToString();
        enemyHealthText.text = _enemyHealth.ToString() + "/" + _enemyMaxHealth.ToString();
        enemyHealthText2.text = _enemyHealth2.ToString() + "/" + _enemyMaxHealth2.ToString();
        enemyHealthText3.text = _enemyHealth3.ToString() + "/" + _enemyMaxHealth3.ToString();

        //update health bars
        playerHealthBar.fillAmount = (float)_playerHealth / (float)_playerMaxHealth;
        enemyHealthBar.fillAmount = (float)_enemyHealth / (float)_enemyMaxHealth;
        enemyHealthBar2.fillAmount = (float)_enemyHealth2 / (float)_enemyMaxHealth2;
        enemyHealthBar3.fillAmount = (float)_enemyHealth3 / (float)_enemyMaxHealth3;

        //update charge bar
        //enemyChargeBar.fillAmount = (float)chargeTime / (float)maxCharge;
    }

    // If we continue to have a full model, if an enemy takes multiple turns to attck, make it so the enemy has a "about to attack" portrait to use against the player 

}
