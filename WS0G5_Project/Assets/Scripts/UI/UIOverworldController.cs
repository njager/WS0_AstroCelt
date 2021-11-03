using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using CodeMonkey.Utils;
using DG.Tweening;

public class UIOverworldController : MonoBehaviour
{
    /// <summary>
    /// This is the Actual Overworld Controller and not the test script. 
    /// </summary>
    /// 

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
    [SerializeField] int treeHealthCount;
    [SerializeField] int treeHealthCountMax = 3;

    // Level 1
    [SerializeField] bool levelOneDefeated;
    private GameObject Level1SkullFull;
    private GameObject Level1SkullBroken;
    private GameObject Level1BlockedX;

    // Level 2
    [SerializeField] bool levelTwoDefeated;
    private GameObject Level2SkullFull;
    private GameObject Level2SkullBroken;
    private GameObject Level2BlockedX;
    // Level 3

    // Level 4

    // Level 5
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
    [SerializeField] GameObject levelSelectButton2;
    [SerializeField] Transform levelSelectPositions;

    private WorldController world;

    // Start is called before the first frame update
    void Start()
    {
        world = WorldController.instance;  
        SetText();

        //grab child components of the level 1 button
        Level1SkullFull = levelSelectButton1.transform.Find("LevelSkullFull").gameObject;
        Level1SkullBroken = levelSelectButton1.transform.Find("LevelSkullBroken").gameObject;
        Level1BlockedX = levelSelectButton1.transform.Find("LevelBlockedX").gameObject;

        Level1SkullFull = levelSelectButton2.transform.Find("LevelSkullFull").gameObject;
        Level1SkullBroken = levelSelectButton2.transform.Find("LevelSkullBroken").gameObject;
        Level1BlockedX = levelSelectButton2.transform.Find("LevelBlockedX").gameObject;

        treeHealthCount = world.overWorldTreeHealth;
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

        // Level 2
        Transform level2SpawnPosOne = levelSelectPositions.Find("Level2Position1");
        Vector3 level2SpawnPosOnePoint = levelOneSpawnPosOne.position;
        Transform level2SpawnPosTwo = levelSelectPositions.Find("Level2Position2");
        Vector3 level2SpawnPosTwoPoint = levelOneSpawnPosTwo.position;
        Transform level2SpawnPosThree = levelSelectPositions.Find("Level2Position3");
        Vector3 level2SpawnPosThreePoint = levelOneSpawnPosThree.position;
        Transform level2SpawnPosFour = levelSelectPositions.Find("Level2Position4");
        Vector3 level2SpawnPosFourPoint = levelOneSpawnPosFour.position;

        treeHealthCount = world.overWorldTreeHealth;

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
            if (turnCount == 0)
            {
                levelSelectButton1.transform.position = levelOneSpawnPosOnePoint;
                isLevel1AtTree = false;
            }
            else if (turnCount == 1)
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
        if (levelOneDefeated)
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

        if (levelTwoDefeated)
        {
            Level2SkullFull.SetActive(false);
            Level2SkullBroken.SetActive(true);
            Level2BlockedX.SetActive(true);
        }
        else if (!levelTwoDefeated)
        {
            Level2SkullFull.SetActive(true);
            Level2SkullBroken.SetActive(false);
            Level2BlockedX.SetActive(false);
        }

        //check tree health
        if (treeHealthCount == 0)
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
        world.overWorldVitality += 1;
    }

    //constellation upgrade button
    public void ConstellationUpgradeButton()
    {
        Debug.Log("You upgraded your max constellation size, nice!");
        world.constellationLimitModifier += 1;
    }

    //ritual one upgrade button
    public void RitualUpgradeButtonOne()
    {
        Debug.Log("You upgraded an ability, nice!");
        world.altarSiphonUpgrade +=1;
    }

    //ritual two upgrade button
    public void RitualUpgradeButtonTwo()
    {
        Debug.Log("You upgraded another ability, nice!");
        world.altarHorizonShiftUpgrade += 1;
    }

    //level select one
    public void LevelSelectButtonOne()
    {
        Debug.Log("You selected a level, good luck!");
        // May not be needed
    }
}
