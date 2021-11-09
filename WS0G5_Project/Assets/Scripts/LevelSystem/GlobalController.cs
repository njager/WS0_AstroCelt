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

    // UI Canvases
    [Header("Canvases")]
    public GameObject winCanvas;
    public GameObject loseCanvas;

    [Header("Constellation Variables")]
    public int constellationPotential = 0; 
    public int constellationPotentialDamage = 0;
    public float constellationFinalDamage = 0f;
    public int constellationPotentialHealth = 0;
    public float constellationFinalHealth = 0;
    public int constellationStarCount = 0;
    public AnimationCurve animationCurveForMultiplier;

    [Header("Turn Management")]
    public GameObject enemyTurnBar; // Let the player know if it's their turn or the enemies turn
    public GameObject playerTurnBar; 

    [Header("Characters")]
    public GameObject player;
    public GameObject enemyForRound1;
    public EnemyScript currentEnemy;
    public Transform enemySpawnPosition; 
    
    [Header("Ints")]
    public int ListCount = 0;
    public int roundCount = 0;
    public int enumeratorCheckBad;
    public int enumeratorCheckGood;

    [Header("Audio")] // For when we implement audio, grab for holders 
    public GameObject testAudioBackgroundMusic;
    public GameObject testAudiosoundEffect1;

    [Header("Lists")]
    public List<Transform> startingStarSpawnPointList = new List<Transform>(); // Transforms used to not use for random spawning stars
    public List<Star> constellationBeingBuilt = new List<Star>(); // Temporary used stars
    public List<Star> constellationFinalStars = new List<Star>(); // Final used stars
    public List<LineRendererScript> lineRendererList = new List<LineRendererScript>(); // Line Renderer list for deletion purposes
    public List<LineRendererScript> lineRendererResetList = new List<LineRendererScript>(); // Specifically a List for Reset
    public List<ObstacleScript> obstacleList = new List<ObstacleScript>();
    public List<int> tempConstellationsFromTurnList = new List<int>();
    public List<int> FinalConstellationsFromTurn = new List<int>();

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

    [Header("PopUp References")]
    public Transform enemyPopUpTransform;
    public Transform playerPopUpTransform;

    [Header("Tags")]
    public string starTag = "Star";

    [Header("Particles")]
    public int abc = 90;

    [Header("Spawning Framework")]
    public GameObject spawningFramework;
    public GameObject oldStarSpawner;

    [Header("UI Variables")]
    public static Transform pfPopup;
    //public WorldController world;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("Somehow more than one GlobalController in scene!");
        }

        instance = this;

        //world = WorldController.instance;
    }

    public void Start()
    {
        Time.timeScale = 1f;
        playerTurnBar.SetActive(true);
        enemyTurnBar.SetActive(false); 
        oldStarSpawner.SetActive(false); 
        winCanvas.SetActive(false);
        loseCanvas.SetActive(false); 
    }

    public void Win()
    {
        winCanvas.SetActive(true);
        Time.timeScale = 0f;
        //SceneManager.LoadSceneAsync("WorldScene");
        //world.overWorldCEAmount += 100;
    }

    public void Lose()
    {
        loseCanvas.SetActive(true);
        Time.timeScale = 0f;
        //SceneManager.LoadSceneAsync("WorldScene");
        //world.overWorldTreeHealth -= 1;
    }

    public void TempAbility() // Using a place holder for the ability, since it's only temp UI anyhow
    {
        Popup.Create(enemyPopUpTransform.position, 5, 1);
        particleSystemScript.SpawnDamageParticleEffect(enemyPopUpTransform);
    }

}
