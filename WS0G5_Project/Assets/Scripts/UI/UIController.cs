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

    [Header("Public Variables")]
    public bool isAttack;
    public bool isHeal;
    public bool isShield;

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
    [SerializeField] GameObject attackTile;
    [SerializeField] Animator attackTileAnimator;
    [SerializeField] GameObject healTile;
    [SerializeField] Animator healTileAnimator;
    [SerializeField] GameObject shieldTile;
    [SerializeField] Animator shieldTileAnimator;
    // [SerializeField] List<Image> confirmTileImages;
    // [SerializeField] Image currentConfirmButtonImage;
    // [SerializeField] Button confirmButton;
    private bool isAttackTileGlow;
    private bool isHealTileGlow;
    private bool isShieldTileGlow;
    private bool isConfirmReady;
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

    //AttackTiles
    private GameObject attackTileNormal;
    private GameObject attackTileGlow;
    private GameObject healTileNormal;
    private GameObject healTileGlow;
    private GameObject shieldTileNormal;
    private GameObject shieldTileGlow;
   // private int confirmTileIndex;

    [Header("Shield UI")]
    [SerializeField] TextMeshProUGUI playerShieldText;
    [SerializeField] TextMeshProUGUI enemy1ShieldText;
    [SerializeField] TextMeshProUGUI enemy2ShieldText;
    [SerializeField] TextMeshProUGUI enemy3ShieldText;

    [SerializeField] int playerShieldVal;
    [SerializeField] int enemy1ShieldVal;
    [SerializeField] int enemy2ShieldVal;
    [SerializeField] int enemy3ShieldVal;

    [SerializeField] int shieldMaxCount;
    [SerializeField] int playerShieldMaxCount;

    [SerializeField] Image playerShieldBar;
    [SerializeField] Image enemy1ShieldBar;
    [SerializeField] Image enemy2ShieldBar;
    [SerializeField] Image enemy3ShieldBar;

    public bool isEnemyDead;

    // UI Colors for Action Stars
    // Damage is DD6666
    // Health is SECC71
    // Shield is 4B6FB7 at 60% opacity


    // Start is called before the first frame update
    void Start()
    {
        global = GlobalController.instance;
        
        // Grabbing Static Variables First
        _enemyCount = StaticVariables.masterEnemyCount;
        _ceCount = PlayerStats.startingPlayerCosmicEnergy;
        _playerHealth = PlayerStats.playerVitality;
        _playerMaxHealth = PlayerStats.startingPlayerVitality;
        _enemyMaxCount = global.staticVariablesReference.returnExpectedEnemyCount();
        // Set Enemy Health
        _enemyHealth = global.enemy1.enemyHealth;
        _enemyHealth2 = global.enemy2.enemyHealth;
        _enemyHealth3 = global.enemy3.enemyHealth;
        _enemyMaxHealth = global.enemy1.enemyStartHealth;
        _enemyMaxHealth2 = global.enemy2.enemyStartHealth;
        _enemyMaxHealth3 = global.enemy3.enemyStartHealth;

        // Set shields
        playerShieldVal = global.playerShieldCount;
        enemy1ShieldVal = global.enemy1ShieldCount;
        enemy2ShieldVal = global.enemy2ShieldCount; 
        enemy3ShieldVal = global.enemy3ShieldCount;

        shieldMaxCount = 5;
        playerShieldMaxCount = 20;

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
        
        //check type of output
        bool isDamage = Random.Range(0, 100) < 60;

        //attackTileNormal = attackTile.transform.Find("AttackTileNormal").gameObject;
        //attackTileGlow = attackTile.transform.Find("AttackTileGlow").gameObject;

        //healTileNormal = healTile.transform.Find("HealTileNormal").gameObject;
        //healTileGlow = healTile.transform.Find("HealTileGlow").gameObject;

        //shieldTileNormal = shieldTile.transform.Find("ShieldTileNormal").gameObject;
        //shieldTileGlow = shieldTile.transform.Find("ShieldTileGlow").gameObject;


        SetText();

        //spawnTimer -= Time.deltaTime;
        //if (spawnTimer < 0)
        {
            //global.popup.Create(new Vector3(-100, 0, 1), 1, 0, true);
            //spawnTimer = 1f;
        }
    }

    void UpdateUIVariables() // Trying to keep Update Clutter down
    {
        _enemyCount = global.staticVariablesReference.returnCurrentEnemyCount();
        _ceCount = PlayerStats.startingPlayerCosmicEnergy;
        _enemyHealth = global.staticVariablesReference.returnCurrentEnemyHealth1();
        _enemyHealth2 = global.staticVariablesReference.returnCurrentEnemyHealth2();
        _enemyHealth3 = global.staticVariablesReference.returnCurrentEnemyHealth3();
        _playerHealth = PlayerStats.playerVitality;
        _playerMaxHealth = PlayerStats.startingPlayerVitality;
        _enemyMaxHealth = global.staticVariablesReference.returnStartEnemyHealth1();
        _enemyMaxHealth2 = global.staticVariablesReference.returnStartEnemyHealth2();
        _enemyMaxHealth3= global.staticVariablesReference.returnStartEnemyHealth3();
        _enemyMaxCount = global.staticVariablesReference.returnExpectedEnemyCount();

        playerShieldVal = global.playerShieldCount;
        enemy1ShieldVal = global.enemy1ShieldCount;
        enemy2ShieldVal = global.enemy2ShieldCount;
        enemy3ShieldVal = global.enemy3ShieldCount;
        return; 
    }

    //sets the text objects
    void SetText()
    {
        // Update UI Text
        enemyCountText.text = _enemyCount.ToString() + "/" + _enemyMaxCount.ToString();
        ceCountText.text = _ceCount.ToString();
        playerHealthText.text = _playerHealth.ToString() + "/" + _playerMaxHealth.ToString();
        enemyHealthText.text = _enemyHealth.ToString() + "/" + _enemyMaxHealth.ToString();
        enemyHealthText2.text = _enemyHealth2.ToString() + "/" + _enemyMaxHealth2.ToString();
        enemyHealthText3.text = _enemyHealth3.ToString() + "/" + _enemyMaxHealth3.ToString();

        playerShieldText.text = playerShieldVal.ToString();
        enemy1ShieldText.text = enemy1ShieldVal.ToString();
        enemy2ShieldText.text = enemy2ShieldVal.ToString();
        enemy3ShieldText.text = enemy3ShieldVal.ToString();

        //update health bars
        playerHealthBar.fillAmount = (float)_playerHealth / (float)_playerMaxHealth;
        enemyHealthBar.fillAmount = (float)_enemyHealth / (float)_enemyMaxHealth;
        enemyHealthBar2.fillAmount = (float)_enemyHealth2 / (float)_enemyMaxHealth2;
        enemyHealthBar3.fillAmount = (float)_enemyHealth3 / (float)_enemyMaxHealth3;

        //update charge bar
        //enemyChargeBar.fillAmount = (float)chargeTime / (float)maxCharge;

        //update Shield Bars
        playerShieldBar.fillAmount = (float)playerShieldVal / (float)playerShieldMaxCount;
        enemy1ShieldBar.fillAmount = (float)enemy1ShieldVal / (float)shieldMaxCount;
        enemy2ShieldBar.fillAmount = (float)enemy2ShieldVal / (float)shieldMaxCount;
        enemy3ShieldBar.fillAmount = (float)enemy3ShieldVal / (float)shieldMaxCount;
    }

    IEnumerator ConfirmAnim()
    {
        if (isAttack)
        {
            attackTileNormal.SetActive(false);
            attackTileGlow.SetActive(true);
            isAttackTileGlow = true;
            attackTileAnimator.SetBool("isAttackTileGlow", true);
        }
        else if (isHeal)
        {
            healTileNormal.SetActive(false);
            healTileGlow.SetActive(true);
            isHealTileGlow = true;
            healTileAnimator.SetBool("isHealTileGlow", true);
        }
        else if (isShield)
        {
            shieldTileNormal.SetActive(false);
            shieldTileGlow.SetActive(true);
            isShieldTileGlow = true;
            shieldTileAnimator.SetBool("isShieldTileGlow", true);
        }


        //add a 2 second delay then don't allow it to be run again
        yield return new WaitForSeconds(2);

        ConfirmTileReset();
    }

    //reset the anims for the confirm button to normal
    void ConfirmTileReset()
    {
        attackTileNormal.SetActive(false);
        attackTileGlow.SetActive(false);
        isAttackTileGlow = false;

        healTileNormal.SetActive(false);
        healTileGlow.SetActive(false);
        isHealTileGlow = false;

        shieldTileNormal.SetActive(false);
        shieldTileGlow.SetActive(false);
        isShieldTileGlow = false;
    }

    // If we continue to have a full model, if an enemy takes multiple turns to attck, make it so the enemy has a "about to attack" portrait to use against the player 

}
