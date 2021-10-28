using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using CodeMonkey.Utils;
using DG.Tweening;

public class UIOverworldTest : MonoBehaviour
{
    //public variables
    public int turnCount;

    //private variables
    [Header("Variables")]
    [SerializeField] int levelsCount;
    [SerializeField] int levelsMaxCount;
    [SerializeField] int ceCount;
    [SerializeField] int talismanCount;
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
        SetText();
    }

    // Update is called once per frame
    void Update()
    {
        //updates the text
        SetText();


        if (Input.GetKeyDown(KeyCode.G))
        {
            turnCount++;
        }
    }

    //sets the text objects
    void SetText()
    {
        levelCountText.text = levelsCount.ToString() + "/" + levelsMaxCount.ToString();
        ceCountText.text = ceCount.ToString();
        talismanCountText.text = talismanCount.ToString();
        vitUpgCostText.text = vitUpgCost.ToString();
        constUpgCostText.text = constUpgCost.ToString();
        ritOneUpgCostText.text = ritOneUpgCost.ToString();
        ritTwoUpgCostText.text = ritTwoUpgCost.ToString();

        //update health bars
        //playerHealthBar.fillAmount = (float)playerHealth / (float)playerMaxHealth;
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
