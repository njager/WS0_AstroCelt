using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI; 

public class DrawingScript : MonoBehaviour
{
    [Header("Variables")]
    public GameObject lineRendererPrefab; 

    private GlobalController global;

    private Vector3 lineStartingPoint;
    private Vector3 lineEndingPoint;

    [Header("Star References")]
    public Star star1;
    public Star star2;
    public Star starNext; // Use Star 2 for star1 after starCount > 0 
    public Star NodeStar;
    public Star nodeStar2;
    public Star emptyStar; // Need something to start the game

    [Header("Drawing Script Ints")]
    public int shouldNextStar; // Used in line renderer count; 
    public int starCount; // Know if drawing for first time

    [Header("Position")]
    public List<Vector3> transformHolder = new List<Vector3>();

    [Header("Star Reporting")]
    public int activeStarCounter = 0;
    public List<Star> usedStarList = new List<Star>();

    public Transform drawingScriptSelf;
    public Quaternion intitalQuaternion;
    public int nodeClickCount = 0; 

    public void Awake()
    {
        //nodeStar2.gameObject.SetActive(false); 
        NodeStar = emptyStar; 
        star1 = NodeStar;
        nodeClickCount = 1;
        activeStarCounter = 1;
    }

    public void Start() 
    {
        starCount = 0; 
        shouldNextStar = 0;
        lineStartingPoint = Vector3.zero;
        lineStartingPoint = Vector3.zero;
        global = GlobalController.instance;
        star1 = NodeStar;
    }

    public void Update()
    {
        
    }

    public void ResetList()
    {
        activeStarCounter = 1;
        starCount = 0;
    }

    public void drawLine()
    {
        if (activeStarCounter == 1)
        {
            GameObject _lineRenderer = Instantiate(lineRendererPrefab); 
            LineRenderer importedLineRenderer = _lineRenderer.GetComponent<LineRenderer>(); 
            LineRendererScript lineScript = _lineRenderer.GetComponent<LineRendererScript>();
            lineScript.SetStars(starNext, star2);
            importedLineRenderer.useWorldSpace = true;
            Debug.Log("Spawned in Line");
            drawingLine(importedLineRenderer, lineScript);
        }
        else
        {
            return; 
        }
    }

    public void drawingLine(LineRenderer importedLineRenderer, LineRendererScript lineScript) 
    {
        if (starCount > 0)
        {
            global.constellationBeingBuilt.Add(star2);
            lineStartingPoint = starNext.transform.position;
            lineEndingPoint = star2.transform.position;
            importedLineRenderer.startWidth = 0.1f;
            importedLineRenderer.endWidth = 0.1f;
            importedLineRenderer.startColor = Color.red;
            importedLineRenderer.endColor = Color.red;
            transformHolder.Add(lineStartingPoint);
            transformHolder.Add(lineEndingPoint);
            importedLineRenderer.SetPositions(transformHolder.ToArray());
            Debug.Log("Added Line to List");
            global.lineRendererList.Add(lineScript);
            starNext = star2;
            global.starSpawnerFrameworkScript.StarReset();
        }
        if (starCount == 0)
        {
            global.constellationBeingBuilt.Add(star1);
            global.constellationBeingBuilt.Add(star2);
            lineStartingPoint = star1.transform.position;
            lineEndingPoint = star2.transform.position;
            importedLineRenderer.startWidth = 0.1f;
            importedLineRenderer.endWidth = 0.1f;
            importedLineRenderer.startColor = Color.red;
            importedLineRenderer.endColor = Color.red;
            transformHolder.Add(lineStartingPoint);
            transformHolder.Add(lineEndingPoint);
            importedLineRenderer.SetPositions(transformHolder.ToArray());
            starNext = star2;
            Debug.Log("Added Line to List");
            global.lineRendererList.Add(lineScript);
            starCount++;
            global.starSpawnerFrameworkScript.StarReset();
        }
        if(starCount == -1)
        {
            global.constellationBeingBuilt.Add(star2);
            lineStartingPoint = starNext.transform.position;
            lineEndingPoint = star2.transform.position;
            importedLineRenderer.startWidth = 0.1f;
            importedLineRenderer.endWidth = 0.1f;
            importedLineRenderer.startColor = Color.white;
            importedLineRenderer.endColor = Color.white;
            transformHolder.Add(lineStartingPoint);
            transformHolder.Add(lineEndingPoint);
            importedLineRenderer.SetPositions(transformHolder.ToArray());
            Debug.Log("Added Line to List");
            global.lineRendererList.Add(lineScript);
            starNext = star2;
            global.starSpawnerFrameworkScript.StarReset();
            global.constellationBuilding.ConstellationBuilt(); 
        }

    }
    
}
