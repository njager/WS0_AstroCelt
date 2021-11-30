using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI;
using TMPro;

public class GlobalController : MonoBehaviour
{
    public static GlobalController instance; // Making Global into the base for inter-script structure. 

    /// <summary>
    /// What making this a static script means is that this particular version will always exist during runtime without having to be attached to an object (though I do so I can store variables in it, but you could just store those variables in instanced scripts)
    /// 
    /// This is extremely useful as an intermediary for having scripts talk to eachother without having to instance a version of that script in another script. By just doing that private GlobalController.instance() I significantly lower the amount of referrel calls needed
    /// since I can have everything referenced and called back to from global. What I do to make it even cleaner is make objects that only hold the script and do nothing else for function calls in the Unity scene, and then put them in script references meaning I can call 
    /// functions in my other script from a completely other scripts 
    /// </summary>

    [Header("Designer Values")]
    public float lowerBoundLine;
    public float upperBoundLine;

    // UI Canvases
    [Header("Canvases")]
    public GameObject winCanvas;
    public GameObject loseCanvas;
    public GameObject uiCanvas;
    public GameObject inWorldCanvas;

    [Header("Selector Variables")]
    public GameObject enemy1ActionIcon;
    public GameObject enemy2ActionIcon;
    public GameObject enemy3ActionIcon;

    [Header("Constellation Variables")]
    public int constellationPotential = 0; 
    public int constellationPotentialDamage = 0;
    public float constellationFinalDamage = 0f;
    public int constellationPotentialHealth = 0;
    public float constellationFinalHealth = 0;
    public int constellationPotentialShield = 0;
    public float constellationFinalShield = 0f;
    public int constellationStarCount = 0;
    public AnimationCurve animationCurveForMultiplier;

    [Header("Turn Management")]
    public GameObject enemyTurnBar; // Let the player know if it's their turn or the enemies turn
    public GameObject playerTurnBar; 

    [Header("Characters")]
    public GameObject player;
    public GameObject enemy1ForRound1;
    public GameObject enemy2ForRound1;
    public GameObject enemy3ForRound1; 
    public EnemyScript enemy1;
    public EnemyScript enemy2;
    public EnemyScript enemy3; 
    public Transform enemySpawnPosition;
    public EnemyScript enemySelected;
    
    [Header("Ints")]
    public int ListCount = 0;
    public int roundCount = 0;
    public int enumeratorCheckBad;
    public int enumeratorCheckGood;

    [Header("Audio")] // For when we implement audio, grab for holders 
    public GameObject testAudioBackgroundMusic;
    public AudioSource m_SoundEffectDamage;
    public AudioSource m_SoundEffectPop;
    public AudioSource m_SoundEffectPopHigh;
    public AudioSource m_SoundEffectConFinish;
    public AudioSource m_SoundEffectWhoosh;
    
    [Header("Altar Text")]
    public GameObject altarText1;
    public GameObject altarText2;
    public GameObject altarText3;
    public GameObject previousText;

    [Header("Lists")]
    public List<Transform> startingStarSpawnPointList = new List<Transform>(); // Transforms used to not use for random spawning stars
    public List<Star> constellationBeingBuilt = new List<Star>(); // Temporary used stars
    public List<Star> constellationFinalStars = new List<Star>(); // Final used stars
    public List<LineRendererScript> lineRendererList = new List<LineRendererScript>(); // Line Renderer list for deletion purposes
    public List<LineRendererScript> lineRendererResetList = new List<LineRendererScript>(); // Specifically a List for Reset
    public List<GameObject> obstacleList;
    public List<(Transform, Transform)> obstacleNewSpawnList = new List<(Transform, Transform)>();
    public List<Star> tempConstellationsFromTurnList = new List<Star>();
    public List<Star> FinalConstellationsFromTurn = new List<Star>();

    [Header("Checkers")]
    public GameObject ResetChecker;

    [Header("Script References")]
    public Star Star; // Needed for inter-script referencing 
    public DrawingScript drawingScript;
    public StarSpawnerFramework starSpawnerFrameworkScript; // Needed for inter-script referencing 
    public PlayerScript playerScript; // Needed for inter-script referencing 
    public EnemyScript enemyScript; // Needed for inter-script referencing 
    public PlayerStats playerStats;
    public UIController UIController; // In Case
    public ResetBehavior resetBehavior; // Needed to trigger the behavior for EnemySwitcherFrameworkScriptt
    public EnemySwitcherScript enemySwitcherFrameworkScript; // InCase
    public StaticVariables staticVariablesReference; // For a method call in UIController
    public NewStarMapScript newStarMapScript; // For use in UIController
    public ConstellationBuildingScript constellationBuilding; // To build constellation
    public Popup popUpReference;
    public ParticleSystemScript particleSystemScript; // For referencing particle systems
    public TurnManager turnManagerScript;
    public SelectorScript selector; 

    [Header("PopUp References")]
    public Transform enemyPopUpTransform;
    public Transform playerPopUpTransform;

    [Header("Spawning Framework")]
    public GameObject spawningFramework;
    public GameObject oldStarSpawner;

    [Header("UI Variables")]
    public static Transform pfPopup;

    public Transform enemyHealthBar1;
    public Transform enemyHealthBar2;
    public Transform enemyHealthBar3;

    [Header("Shielding UI")]
    public GameObject enemy1ShieldUI;
    public GameObject enemy2ShieldUI;
    public GameObject enemy3ShieldUI;

    public GameObject enemy1UI;
    public GameObject enemy2UI;
    public GameObject enemy3UI;

    public bool enemy1Shielded;
    public bool enemy2Shielded;
    public bool enemy3Shielded;

    public bool enemy1Attacking;
    public bool enemy2Attacking;
    public bool enemy3Attacking;

    public GameObject enemy1ShieldGraphic;
    public GameObject enemy2ShieldGraphic;
    public GameObject enemy3ShieldGraphic;

    public int playerShieldCount; // Set to 2
    public int enemy1ShieldCount; // Set to 2
    public int enemy2ShieldCount; // Set to 2
    public int enemy3ShieldCount; // Set to 2

    //public WorldController world;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("Somehow more than one GlobalController in scene!");
        }

        instance = this;

        obstacleList = new List<GameObject>();
        //world = WorldController.instance;

        playerShieldCount = 0;
        enemy1ShieldCount = 5;
        enemy2ShieldCount = 5;
        enemy3ShieldCount = 5;

        enemy1Shielded = false;
        enemy2Shielded = false;
        enemy3Shielded = false;
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) // Use this to End Turn As Well
        {
            //SceneManager.LoadSceneAsync("PrototypeScene");
            //Win();
            //Lose();
            //playerShieldCount -= 10;
            enemy1.enemyDie();
        }
        if(PlayerStats.playerVitality <= 0)
        {
            Lose();
        }
    }

    public void Start()
    {
        Time.timeScale = 1f;
        playerTurnBar.SetActive(true);
        enemyTurnBar.SetActive(false);
        oldStarSpawner.SetActive(false); 
        winCanvas.SetActive(false);
        loseCanvas.SetActive(false);
        altarText1.SetActive(false);
        altarText2.SetActive(false);
        altarText3.SetActive(false);
        previousText = null;
        AltarSelection(); 
    }

    public void AltarSelection()
    {
        int altarTextSelector = Random.Range(1, 4);
        if (altarTextSelector == 1)
        {
            if (previousText == null)
            {
                previousText = altarText1;
                altarText1.SetActive(true);
                altarText2.SetActive(false);
                altarText3.SetActive(false);
                //Debug.Log("Setting Altar 1");
                return; 
            }
            else
            {
                if(previousText == altarText1)
                {
                    int alternateAltarTextSelector = Random.Range(1, 3);
                    if(alternateAltarTextSelector == 1)
                    {
                        previousText = altarText2;
                        altarText1.SetActive(false);
                        altarText2.SetActive(true);
                        altarText3.SetActive(false);
                        //Debug.Log("Setting Altar 2");
                        return;
                    }
                    if (alternateAltarTextSelector == 2)
                    {
                        previousText = altarText3;
                        altarText1.SetActive(false);
                        altarText2.SetActive(false);
                        altarText3.SetActive(true);
                        //Debug.Log("Setting Altar 3");
                        return;
                    }
                }
                else
                {
                    previousText = altarText1;
                    altarText1.SetActive(true);
                    altarText2.SetActive(false);
                    altarText3.SetActive(false);
                    //Debug.Log("Setting Altar 1");
                    return; 
                }
            }
        }
        if (altarTextSelector == 2)
        {
            if (previousText == null)
            {
                previousText = altarText2;
                altarText1.SetActive(false);
                altarText2.SetActive(true);
                altarText3.SetActive(false);
                //Debug.Log("Setting Altar 2");
                return;
            }
            else
            {
                if (previousText == altarText2)
                {
                    int alternateAltarTextSelector = Random.Range(1, 3);
                    if (alternateAltarTextSelector == 1)
                    {
                        previousText = altarText1;
                        altarText1.SetActive(true);
                        altarText2.SetActive(false);
                        altarText3.SetActive(false);
                        //Debug.Log("Setting Altar 1");
                        return;
                    }
                    if (alternateAltarTextSelector == 2)
                    {
                        previousText = altarText3;
                        altarText1.SetActive(false);
                        altarText2.SetActive(false);
                        altarText3.SetActive(true);
                        //Debug.Log("Setting Altar 3");
                        return;
                    }
                }
                else
                {
                    previousText = altarText2;
                    altarText1.SetActive(false);
                    altarText2.SetActive(true);
                    altarText3.SetActive(false);
                    //Debug.Log("Setting Altar 2");
                    return;

                }
            }
        }
        if (altarTextSelector == 3)
        {
            if (previousText == null)
            {
                previousText = altarText3;
                altarText1.SetActive(false);
                altarText2.SetActive(false);
                altarText3.SetActive(true);
                //Debug.Log("Setting Altar 3");
                return;
            }
        }
        else
        {
            if (previousText == altarText3)
            {
                int alternateAltarTextSelector = Random.Range(1, 3);
                if (alternateAltarTextSelector == 1)
                {
                    previousText = altarText1;
                    altarText1.SetActive(true);
                    altarText2.SetActive(false);
                    altarText3.SetActive(false);
                    //Debug.Log("Setting Altar 1");
                    return;
                }
                if (alternateAltarTextSelector == 2)
                {
                    previousText = altarText2;
                    altarText1.SetActive(false);
                    altarText2.SetActive(true);
                    altarText3.SetActive(false);
                    //Debug.Log("Setting Altar 2");
                    return;
                }
            }
            else
            {
                previousText = altarText3;
                altarText1.SetActive(false);
                altarText2.SetActive(false);
                altarText3.SetActive(true);
                //Debug.Log("Setting Altar 3");
                return;
            }
        }
    }

    public void RetryButton()
    {
        SceneManager.LoadSceneAsync("PrototypeScene");
    }

    public void EndConditions()
    {
        //Time.timeScale = 0f;
        uiCanvas.SetActive(false);
        inWorldCanvas.SetActive(false);
        starSpawnerFrameworkScript.ClearStars();
        starSpawnerFrameworkScript.ClearPoints();
        starSpawnerFrameworkScript.ClearLines();
        starSpawnerFrameworkScript.HCObstacleSwitcher(-1);
        drawingScript.NodeStar.gameObject.SetActive(false);
        player.SetActive(false);
        enemy1ForRound1.SetActive(false);
        enemy2ForRound1.SetActive(false);
        enemy3ForRound1.SetActive(false);
        StaticVariables.masterEnemyCount = 0;
        return; 
    }

    public void Win()
    {
        winCanvas.SetActive(true);
        EndConditions(); 
        //SceneManager.LoadSceneAsync("WorldScene");
        //world.overWorldCEAmount += 100;
    }

    public void Lose()
    {
        loseCanvas.SetActive(true);
        EndConditions();
        //SceneManager.LoadSceneAsync("WorldScene");
        //world.overWorldTreeHealth -= 1;
    }

}
