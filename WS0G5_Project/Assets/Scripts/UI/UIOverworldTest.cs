using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using CodeMonkey.Utils;
using DG.Tweening;

public class UIOverworldTest : MonoBehaviour
{
    //private variables
    [Header("Variables")]
    [SerializeField] int levelsCount;
    [SerializeField] int levelsMaxCount;
    [SerializeField] int ceCount;
    [SerializeField] int vitUpgCost;
    [SerializeField] int constUpgCost;
    [SerializeField] int ritOneUpgCost;
    [SerializeField] int ritTwoUpgCost;

    //UI variables
    [Header("UI Element Slots")]
    [SerializeField] TextMeshProUGUI ceCountText;
    [SerializeField] TextMeshProUGUI levelCountText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //sets the text objects
    void SetText()
    {
        /*enemyCountText.text = enemyCount.ToString() + "/" + enemyMaxCount.ToString();
        ceCountText.text = ceCount.ToString();
        playerHealthText.text = playerHealth.ToString() + "/" + playerMaxHealth.ToString();
        enemyHealthText.text = enemyHealth.ToString() + "/" + enemyMaxHealth.ToString();

        //update health bars
        playerHealthBar.fillAmount = (float)playerHealth / (float)playerMaxHealth;
        enemyHealthBar.fillAmount = (float)enemyHealth / (float)enemyMaxHealth;

        //update charge bar
        enemyChargeBar.fillAmount = (float)chargeTime / (float)maxCharge;*/
    }
}
