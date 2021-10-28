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
    [SerializeField] TextMeshProUGUI talismanCountText;
    [SerializeField] TextMeshProUGUI vitUpgCostText;
    [SerializeField] TextMeshProUGUI constUpgCostText;
    [SerializeField] TextMeshProUGUI ritOneUpgCostText;
    [SerializeField] TextMeshProUGUI ritTwoUpgCostText;

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

    //vitality upgrade button
    public void VitalityUpgradeButton()
    {
        Debug.Log("You upgraded your vitality, nice!");
    }

    //constellation upgrade button
    public void ConstellationUpgradeButton()
    {
        Debug.Log("You upgraded your max constellation size, nice!");
    }

    //ritual one upgrade button
    public void RitualUpgradeButtonOne()
    {
        Debug.Log("You upgraded an ability, nice!");
    }

    //ritual two upgrade button
    public void RitualUpgradeButtonTwo()
    {
        Debug.Log("You upgraded another ability, nice!");
    }

    //level select one
    public void LevelSelectButtonOne()
    {
        Debug.Log("You selected a level, good luck!");
    }
}
