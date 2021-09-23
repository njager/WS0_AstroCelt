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

    [Header("Test Int")]
    public int testVar = 50;

    [Header("LineRenderer")]
    public LineRenderer lineRenderer;
    public bool lineDrawn;

    [Header("Audio")]
    public AudioSource testAudioBackgroundMusic;
    public AudioSource testAudiosoundEffect1;

    [Header("Lists")]
    public List<GameObject> startingStarList;
    public List<RaycastHit2D> activeStarList;
    public List<GameObject> usedStarList;

    [Header("Arrays")]
    public GameObject[] startingStarArray; 
    public GameObject[] activeStarArray;
    public GameObject[] usedStarArray; 

    [Header("Checkers")]
    public GameObject ResetChecker;

    [Header("Script References")]
    public Star Star; 

    [Header("Tags")]
    public string starTag = "Star";

    [Header("Particles")]
    public int abc = 90;

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
        
    }

    void Starlister()
    {
        startingStarArray = GameObject.FindGameObjectsWithTag(starTag);
    }

    public void Update()
    {
        Starlister();

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse was clicked");
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            RaycastHit2D objectHit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (objectHit.collider != null)
            {
                if (objectHit.collider.tag == starTag) 
                {
                    activeStarList.Add(objectHit);
                }
            }
        }
    }

    
}
