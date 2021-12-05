using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HoverTextScript : MonoBehaviour
{
    /// <summary>
    /// Been a bit since we made a new script, just a bit easier to keep clean for right now compared to working in UI Controller
    /// </summary>

    private GlobalController global;

    void Start()
    {
        global = GlobalController.instance;

        // These are only active while an enemy is moused over
        global.enemyHoverTextBox1.SetActive(false);
        global.enemyHoverTextBox2.SetActive(false);
        global.enemyHoverTextBox3.SetActive(false);

        global.lineMultiplierAmount = 0.0f;
        global.UILineAmount = 0.0f; 
    }

    // Update the Hover Text Elements every frame
    void Update()
    {
        SetHoverText();
        global.lineMultiplierAmount = Mathf.Round(EvaluateLineText() * 10f) / 10f;

        if(global.lineMultiplierAmount > 1.5f)
        {
            if (global.lineMultiplierAmount < 3.5f)
            {
                global.UILineAmount = 1.5f;
            }
            else
            {
                global.UILineAmount = 2.0f;
            }
        }
        else
        {
            global.UILineAmount = 1.0f; 
        }
    }

    public float EvaluateLineText()
    {
        float _LineMultiplier = global.constellationBuilding.LineMultiplierCalculator();
        return _LineMultiplier; 
    }

    // Set The Text of the Hover Text
    public void SetHoverText()
    {
        // Hover Text
        global.enemyHoverText1.text = "Expected DMG: " + global.enemy1.enemyDamage.ToString();
        global.enemyHoverText2.text = "Expected DMG: " + global.enemy2.enemyDamage.ToString();
        global.enemyHoverText3.text = "Expected DMG: " + global.enemy3.enemyDamage.ToString();

        // Line Calculator
        global.lineMultText.text = "Star Multiplier: " + global.UILineAmount.ToString() + "x";
    }
}
