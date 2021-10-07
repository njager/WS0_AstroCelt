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
    public StarClass starClass;
    public CharacterStats characterStats;
    public ConstellatonHolder constellatonHolder; 

    [Header("Ints")]
    public int ListCount = 0;
    public int cosmicEnergy; // Move to player stats 

    [Header("Audio")]
    public GameObject testAudioBackgroundMusic;
    public GameObject testAudiosoundEffect1;

    [Header("Lists")]
    public List<Star> startingStarList;
    public List<Star> activeStarList;
    public List<Star> usedStarList;

    [Header("Arrays")]
    public GameObject[] startingStarArray; 
    public GameObject[] activeStarArray;
    public GameObject[] usedStarArray;

    [Header("Checkers")]
    public GameObject ResetChecker;

    [Header("Script References")]
    public Star Star;
    public DrawingScript drawingScript;
    public StarSpawnerFramework starSpawnerFrameworkScript; 

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
        oldStarSpawner.SetActive(false); 
        Starlister();
        Vector3 distance = new Vector3(0f,0f,0f);  
    }

    void Starlister()
    {
        startingStarArray = GameObject.FindGameObjectsWithTag(starTag);
    }

    public void Update()
    {
       
    }

    public void drawLine(GameObject constellationLine, Vector3 initialPosition, Vector3 finalPosition)
    {
        var distance = 0f; 
        Vector3 centerPos = (initialPosition + finalPosition) / 2f;

        constellationLine.transform.position = centerPos;

        Vector3 direction = finalPosition - initialPosition;
        direction = Vector3.Normalize(direction);
        constellationLine.transform.right = direction;

        distance = Vector3.Distance(initialPosition, finalPosition);

        Debug.DrawLine(initialPosition, finalPosition);

        constellationLine.GetComponent<RectTransform>().sizeDelta = new Vector3(distance, 40f);
    }
}
