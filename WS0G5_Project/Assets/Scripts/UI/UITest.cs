using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using CodeMonkey.Utils;
using DG.Tweening;

public class UITest : MonoBehaviour
{
    //public variables
    //[Header("Public Variables")]
    //public static Transform pfPopup;
    //public Vector3 enemyPos;

    //private variables
    [Header("Variables")]
    [SerializeField] int enemyCount;
    [SerializeField] int enemyMaxCount;
    [SerializeField] float timer;
    [SerializeField] int ceCount;
    [SerializeField] int playerHealth;
    [SerializeField] int playerMaxHealth;
    [SerializeField] int enemyHealth;
    [SerializeField] int enemyMaxHealth;
    [SerializeField] float chargeTime;
    [SerializeField] float maxCharge;
    [SerializeField] bool isNone;
    [SerializeField] bool isAttack;
    [SerializeField] bool isHeal;
    [SerializeField] bool isShield; 
    private float spawnTimer = 1f;
    private GameObject attackTileNormal;
    private GameObject attackTileGlow;
    private GameObject healTileNormal;
    private GameObject healTileGlow;
    private GameObject shieldTileNormal;
    private GameObject shieldTileGlow;
    private bool isAttackTileGlow;
    private bool isHealTileGlow;
    private bool isShieldTileGlow;
    private bool isConfirmReady;
    int confirmTileIndex;
    

    //UI variables
    [Header("UI Element Slots")]
    [SerializeField] TextMeshProUGUI ceCountText;
    [SerializeField] TextMeshProUGUI enemyCountText;
    [SerializeField] TextMeshProUGUI playerHealthText;
    [SerializeField] TextMeshProUGUI enemyHealthText;
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] Image playerHealthBar;
    [SerializeField] Image enemyHealthBar;
    [SerializeField] Transform enemyHealthBarPos;
    [SerializeField] Image enemyChargeBar;
    [SerializeField] GameObject attackTile;
    [SerializeField] Animator attackTileAnimator;
    [SerializeField] GameObject healTile;
    [SerializeField] Animator healTileAnimator;
    [SerializeField] GameObject shieldTile;
    [SerializeField] Animator shieldTileAnimator;
    [SerializeField] List<Image> confirmTileImages;
    [SerializeField] Image currentConfirmButtonImage;
    [SerializeField] Button confirmButton;
    [SerializeField] Transform popupPosTest;


    // Start is called before the first frame update
    void Start()
    {
        //Set up the text
        SetText();
        //Popup.Create(Vector3.zero, 5);
        DOTween.Init();

        //set up images for the confirm button
        confirmTileIndex = 0;
        //confirmButton.image = confirmTileImages[confirmTileIndex];

        //grab child components of the level 1 button
        attackTileNormal = attackTile.transform.Find("AttackTileNormal").gameObject;
        attackTileGlow = attackTile.transform.Find("AttackTileGlow").gameObject;

        healTileNormal = healTile.transform.Find("HealTileNormal").gameObject;
        healTileGlow = healTile.transform.Find("HealTileGlow").gameObject;

        shieldTileNormal = shieldTile.transform.Find("ShieldTileNormal").gameObject;
        shieldTileGlow = shieldTile.transform.Find("ShieldTileGlow").gameObject;

        //set up bools
        isConfirmReady = false;

        //find enemy health bar
        //enemyPos = enemyHealthBarPos.position;
    }

    // Update is called once per frame
    void Update()
    {
        //timer code
        float t = Time.timeSinceLevelLoad; // time since scene loaded
        int seconds = (int)(t % 60); // return the remainder of the seconds divide by 60 as an int
        t /= 60; // divide current time y 60 to get minutes
        int minutes = (int)(t % 60); //return the remainder of the minutes divide by 60 as an int
        timerText.text = string.Format("{0}:{1}", minutes.ToString("00"), seconds.ToString("00"));

        //set the charge timer and reset
        chargeTime += Time.deltaTime;
        if(chargeTime >= maxCharge)
        {
            chargeTime = 0;
        }

        //check type of output
        //bool isDamage = Random.Range(0, 100) < 60;

        //cycle popup spawning
        spawnTimer -= Time.deltaTime;
        if(spawnTimer < 0)
        {
            Popup.Create(new Vector3(-100, 0, 1), 1, 0, true);
            spawnTimer = 1f;
        }

        //update the text
        SetText();

        //test popup
        if (Input.GetMouseButtonDown(0))
        {
            Popup.Create(UtilsClass.GetMouseWorldPosition(), 9, 0, true);
        }
        else if (Input.GetMouseButtonDown(1))
        {
            Popup.Create(UtilsClass.GetMouseWorldPosition(), 9, 1, false);
        }
        else if (Input.GetMouseButtonDown(2))
        {
            Popup.Create(UtilsClass.GetMouseWorldPosition(), 9, 2, true);
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            Popup.Create(new Vector3(21, 7, 0), 5, 1, true);
        }

        //debug controls for the tile feedback
        if (Input.GetKeyDown(KeyCode.T))
        {
            //debug control to use the confirm button
            ConfirmTileGo();
        }
        else if (Input.GetKeyDown(KeyCode.Y))
        {
            //debug control to set the confirm button ready
            isConfirmReady = true;
        }

        //debug controls for selecting confirm button image index
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (isNone)
            {
                confirmTileIndex = 0;
            }
            else if (isAttack)
            {
                confirmTileIndex = 1;
            }
            else if (isHeal)
            {
                confirmTileIndex = 3;
            }
            else if (isShield)
            {
                confirmTileIndex = 5;
            }
        }
        //debug control for setting confirm button image
        if (Input.GetKeyDown(KeyCode.O))
        {
            currentConfirmButtonImage = confirmTileImages[confirmTileIndex];
            confirmButton.image = currentConfirmButtonImage;
        }

        /*if (Input.GetKeyDown(KeyCode.W))
        {
            popupPosTest.DOMove(enemyPos, 2f);
        }*/

    }

    //sets the text objects
    void SetText()
    {
        enemyCountText.text = enemyCount.ToString() + "/" + enemyMaxCount.ToString();
        ceCountText.text = ceCount.ToString();
        playerHealthText.text = playerHealth.ToString() + "/" + playerMaxHealth.ToString();
        enemyHealthText.text = enemyHealth.ToString() + "/" + enemyMaxHealth.ToString();

        //update health bars
        playerHealthBar.fillAmount = (float)playerHealth / (float)playerMaxHealth;
        enemyHealthBar.fillAmount = (float)enemyHealth / (float)enemyMaxHealth;

        //update charge bar
        enemyChargeBar.fillAmount = (float)chargeTime / (float)maxCharge;
    }

    //function for making new stars
    public void NewStarsButton()
    {
        Debug.Log("You made some new stars, nice!");
    }

    //confirm button function
    /*public void ConfirmTileGo()
    {
        //if it's ready, run the anims
        if (isConfirmReady)
        {
            StartCoroutine("ConfirmAnim");
            //INPUT HERE the actual effect of the button
        }
        //if it's not ready, don't run the anims
        else if (!isConfirmReady)
        {
            ConfirmTileReset();
        }
        
    }*/

    //run the animations for the confirm button
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
}
