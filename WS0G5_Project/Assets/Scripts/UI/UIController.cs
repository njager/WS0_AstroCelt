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
    [SerializeField] float chargeTime;
    [SerializeField] float maxCharge;
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
    [SerializeField] Image enemyChargeBar;

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
        _enemyHealth = global.currentEnemy.enemyHealth;
        _playerHealth = PlayerStats.playerVitality;
        _playerMaxHealth = PlayerStats.startingPlayerVitality;
        _enemyMaxHealth = global.currentEnemy.enemyStartHealth;
        _enemyMaxCount = global.staticVariablesReference.returnExpectedEnemyCount();
        maxCharge = global.currentEnemy.turnsBetweenAttacks;

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
        timerText.text = string.Format("{0}:{1}", minutes.ToString("00"), seconds.ToString("00"));

        //set the charge timer and reset
        if(isEnemyDead == false)
        {
            chargeTime += Time.deltaTime;
            if (chargeTime >= maxCharge)
            {
                chargeTime = 0;
                global.currentEnemy.enemyAttacksPlayer(global.currentEnemy.enemyDamage);
            }
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

        //update health bars
        playerHealthBar.fillAmount = (float)_playerHealth / (float)_playerMaxHealth;
        enemyHealthBar.fillAmount = (float)_enemyHealth / (float)_enemyMaxHealth;

        //update charge bar
        enemyChargeBar.fillAmount = (float)chargeTime / (float)maxCharge;
    }

}
