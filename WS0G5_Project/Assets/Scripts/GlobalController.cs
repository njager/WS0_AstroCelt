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
    public GameObject testAudioBackgroundMusic;
    public GameObject testAudiosoundEffect1;

    [Header("Lists")]
    List<GameObject> startingStarList = new List<GameObject>();
    List<GameObject> activeStarList = new List<GameObject>();
    List<GameObject> usedStarlistStarList = new List<GameObject>();
    // public GameObject[] activeStarList;
    // public GameObject[] usedStarList; 

    [Header("Checkers")]
    public GameObject ResetChecker;

    [Header("Tags")]
    public string starTag = "Star";

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
        startingStarList = GameObject.FindGameObjectsWithTag(starTag);
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
