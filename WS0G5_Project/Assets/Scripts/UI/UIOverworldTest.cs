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
    public int damageStarLoadCount;
    public int healStarLoadCount;

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
    [SerializeField] int treeHealthCount = 3;
    [SerializeField] int treeHealthCountMax = 3;
    [SerializeField] bool levelOneDefeated;
    private GameObject Level1SkullFull;
    private GameObject Level1SkullBroken;
    private GameObject Level1BlockedX;
    private bool isLevel1AtTree;

    //UI variables
    [Header("UI Element Slots")]
    [SerializeField] TextMeshProUGUI ceCountText;
    [SerializeField] TextMeshProUGUI levelCountText;
    [SerializeField] TextMeshProUGUI talismanCountText;
    [SerializeField] TextMeshProUGUI vitUpgCostText;
    [SerializeField] TextMeshProUGUI constUpgCostText;
    [SerializeField] TextMeshProUGUI ritOneUpgCostText;
    [SerializeField] TextMeshProUGUI ritTwoUpgCostText;
    [SerializeField] TextMeshProUGUI treeHealthCountText;
    [SerializeField] Image treeHealthBar;
    [SerializeField] GameObject levelSelectButton1;
    [SerializeField] Transform levelSelectPositions;
    [SerializeField] GameObject actionStarLoadoutPanel;

    // Start is called before the first frame update
    void Start()
    {
        SetText();

        //grab child components of the level 1 button
        Level1SkullFull = levelSelectButton1.transform.Find("LevelSkullFull").gameObject;
        Level1SkullBroken = levelSelectButton1.transform.Find("LevelSkullBroken").gameObject;
        Level1BlockedX = levelSelectButton1.transform.Find("LevelBlockedX").gameObject;

    }

    // Update is called once per frame
    void Update()
    {
        //updates the text
        SetText();

        //sets the transforms and positions for level 1 tile spots
        Transform levelOneSpawnPosOne = levelSelectPositions.Find("Level1Position1");
        Vector3 levelOneSpawnPosOnePoint = levelOneSpawnPosOne.position;
        Transform levelOneSpawnPosTwo = levelSelectPositions.Find("Level1Position2");
        Vector3 levelOneSpawnPosTwoPoint = levelOneSpawnPosTwo.position;
        Transform levelOneSpawnPosThree = levelSelectPositions.Find("Level1Position3");
        Vector3 levelOneSpawnPosThreePoint = levelOneSpawnPosThree.position;
        Transform levelOneSpawnPosFour = levelSelectPositions.Find("Level1Position4");
        Vector3 levelOneSpawnPosFourPoint = levelOneSpawnPosFour.position;

        //debugging controls
        if (Input.GetKeyDown(KeyCode.G))
        {
            turnCount++;
            if (isLevel1AtTree)
            {
                treeHealthCount--;
            }
        }
        else if (Input.GetKeyDown(KeyCode.H))
        {
            levelOneDefeated = true;
        }
        else if (Input.GetKeyDown(KeyCode.J))
        {
            //depending on turn count, move position of the level button
            if(turnCount == 0)
            {
                levelSelectButton1.transform.position = levelOneSpawnPosOnePoint;
                isLevel1AtTree = false;
            }
            else if(turnCount == 1)
            {
                levelSelectButton1.transform.position = levelOneSpawnPosTwoPoint;
                isLevel1AtTree = false;
            }
            else if (turnCount == 2)
            {
                levelSelectButton1.transform.position = levelOneSpawnPosThreePoint;
                isLevel1AtTree = false;
            }
            else if (turnCount == 3)
            {
                levelSelectButton1.transform.position = levelOneSpawnPosFourPoint;
                isLevel1AtTree = true;
            }
        }

        //change appearance of level one button if defeated
        if(levelOneDefeated)
        {
            Level1SkullFull.SetActive(false);
            Level1SkullBroken.SetActive(true);
            Level1BlockedX.SetActive(true);
        }
        else if (!levelOneDefeated)
        {
            Level1SkullFull.SetActive(true);
            Level1SkullBroken.SetActive(false);
            Level1BlockedX.SetActive(false);
        }

        //check tree health
        if(treeHealthCount == 0)
        {
            Debug.Log("You lose, the tree has died!");
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
        treeHealthCountText.text = treeHealthCount.ToString() + "/" + treeHealthCountMax.ToString();

        //update health bars
        treeHealthBar.fillAmount = (float)treeHealthCount / (float)treeHealthCountMax;
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

    //confirm the action star loadout
    //disable the panel, lock in variables
    public void ConfirmActionStarLoadout()
    {
        actionStarLoadoutPanel.SetActive(false);
    }

    //open the action star loadout panel
    public void OpenActionStarLoadout()
    {
        actionStarLoadoutPanel.SetActive(true);
    }
}
