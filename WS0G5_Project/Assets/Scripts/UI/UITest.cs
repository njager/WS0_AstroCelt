using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UITest : MonoBehaviour
{
    //public variables


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

    //UI variables
    [Header("UI Element Slots")]
    [SerializeField] TextMeshProUGUI ceCountText;
    [SerializeField] TextMeshProUGUI enemyCountText;
    [SerializeField] TextMeshProUGUI playerHealthText;
    [SerializeField] TextMeshProUGUI enemyHealthText;
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] Image playerHealthBar;
    [SerializeField] Image enemyHealthBar;


    // Start is called before the first frame update
    void Start()
    {
        //Set up the text
        SetText();
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

        //update the text
        SetText();
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
    }
}
