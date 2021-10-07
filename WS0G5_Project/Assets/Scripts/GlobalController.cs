using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GlobalController : MonoBehaviour
{
    public static GlobalController instance; // Making Global into the base for inter-script structure. 

    // Attribute system
    [Header("Classes")]
    // public StarClass starClass;
    // public CharacterStats characterStats;
    // public ConstellatonHolder constellatonHolder;

    // UI Canvases
    [Header("Canvases")]
    public GameObject winCanvas;
    public GameObject loseCanvas;

    [Header("Constellation Variables")]
    public int constellationPotential = 0; 
    public int constellationPotentialDamage = 0;
    public int constellationFinalDamage = 0;
    public int constellationPotentialHealth = 0;
    public int constellationFinalHealth = 0; 

    [Header("Characters")]
    public GameObject player;
    public GameObject enemyForRound1;
    
    [Header("Ints")]
    public int ListCount = 0;
    public int roundCount = 0; 

    [Header("Audio")]
    public GameObject testAudioBackgroundMusic;
    public GameObject testAudiosoundEffect1;

    [Header("Lists")]
    public List<Transform> startingStarSpawnPointList = new List<Transform>();
    public List<Star> constellationBeingBuilt = new List<Star>();
    public List<Star> constellationBaseStarPotential = new List<Star>();
    public List<Star> constellationHealthStarPotential = new List<Star>();
    public List<Star> constellationDamageStarPotential = new List<Star>();

    [Header("Checkers")]
    public GameObject ResetChecker;

    [Header("Script References")]
    public Star Star;
    public DrawingScript drawingScript;
    public StarSpawnerFramework starSpawnerFrameworkScript;
    public PlayerStats playerStats; 

    [Header("Tags")]
    public string starTag = "Star";

    [Header("Particles")]
    public int abc = 90;

    [Header("Spawning Framework")]

    public GameObject spawningFramework;
    public GameObject oldStarSpawner;

    // Private 
    private Star starToBeSelected; 
    private Star selectedStar;

    // Borrowed from Brackey's, Reports on Internal state of a private variable publicly 
    public bool starWasSelected { get { return starToBeSelected != null; } }

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("Somehow more than one GlobalController in scene!");
        }

        instance = this;
    }

    public void Start()
    {
        Time.timeScale = 1f; 
        oldStarSpawner.SetActive(false); 
        winCanvas.SetActive(false);
        loseCanvas.SetActive(false); 
    }

    public void Update()
    {
       
    }

    public void Win()
    {
        winCanvas.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Lose()
    {
        loseCanvas.SetActive(true);
        Time.timeScale = 0f;
    }
    public void ConstelltionBuilding()
    {
        foreach (Star star in constellationBeingBuilt.ToList())
        {
            if(star.myStarClass.starType == "BaseStar")
            {
                constellationPotential += star.myStarClass.constellationValue; 

            }
        }
    }

    public void ConstelltionBuilt()
    {

    } 
}
