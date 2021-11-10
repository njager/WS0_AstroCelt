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
    private float spawnTimer = 1f;
    private GameObject attackTileNormal;
    private GameObject attackTileGlow;
    private bool isAttackTileGlow;
    private bool isConfirmReady;

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
    [SerializeField] GameObject attackTile;
    [SerializeField] Animator attackTileAnimator;


    // Start is called before the first frame update
    void Start()
    {
        //Set up the text
        SetText();
        //Popup.Create(Vector3.zero, 5);
        DOTween.Init();

        //grab child components of the level 1 button
        attackTileNormal = attackTile.transform.Find("AttackTileNormal").gameObject;
        attackTileGlow = attackTile.transform.Find("AttackTileGlow").gameObject;

        //set up bools
        isConfirmReady = false;
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
            Popup.Create(new Vector3(-100, 0, 1), 1, 0);
            spawnTimer = 1f;
        }

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
        if (Input.GetMouseButtonDown(0))
        {
            Popup.Create(UtilsClass.GetMouseWorldPosition(), 9, 0);
        }
        else if (Input.GetMouseButtonDown(1))
        {
            Popup.Create(UtilsClass.GetMouseWorldPosition(), 9, 1);
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
    public void ConfirmTileGo()
    {
        //if it's ready, run the anims
        if (isConfirmReady)
        {
            StartCoroutine("ConfirmAnim");
        }
        //if it's not ready, don't run the anims
        else if (!isConfirmReady)
        {
            ConfirmTileReset();
        }
        
    }

    //run the animations for the confirm button
    IEnumerator ConfirmAnim()
    {
        attackTileNormal.SetActive(false);
        attackTileGlow.SetActive(true);
        isAttackTileGlow = true;
        attackTileAnimator.SetBool("isAttackTileGlow", true);

        //add a 2 second delay then don't allow it to be run again
        yield return new WaitForSeconds(2);

        isConfirmReady = false;
    }

    //reset the anims for the confirm button to normal
    void ConfirmTileReset()
    {
        attackTileNormal.SetActive(true);
        attackTileGlow.SetActive(false);
        isAttackTileGlow = false;
        isConfirmReady = true;
    }
}
