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

    public Star star1;
    public Star star2;
    public Star starNext; // Use Star 2 for star1 after starCount > 0 
    public Star startingStar;

    public int starCount; // Know if drawing for first time

    [Header("Position")]
    public List<Vector3> transformHolder = new List<Vector3>();

    [Header("Star Reporting")]
    public int activeStarCounter = 0;
    public List<Star> usedStarList = new List<Star>();

    public Transform drawingScriptSelf;
    public Quaternion intitalQuaternion;

    public void Start() 
    {
        starCount = 0; 
        lineStartingPoint = Vector3.zero;
        lineStartingPoint = Vector3.zero;
        global = GlobalController.instance;
    }

    public void ResetList()
    {
        activeStarCounter = 0;
        starCount = 0;
    }

    public void drawLine()
    {
        if (activeStarCounter == 1)
        {
            GameObject _lineRenderer = Instantiate(lineRendererPrefab); 
            LineRenderer importedLineRenderer = _lineRenderer.GetComponent<LineRenderer>(); 
            LineRendererScript lineScript = _lineRenderer.GetComponent<LineRendererScript>();
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
            lineScript.SetStars(starNext, star2); // Should give stars to specific instance of LineRendererScript
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
            starNext = star2;
            global.starSpawnerFrameworkScript.StarReset();
        }
        if (starCount == 0)
        {
            lineScript.SetStars(star1, star2);
            global.constellationBeingBuilt.Add(star1);
            global.constellationBeingBuilt.Add(star2);
            lineStartingPoint = star1.transform.position;
            lineEndingPoint = star2.transform.position;

            importedLineRenderer.startWidth = 0.1f;
            importedLineRenderer.endWidth = 0.1f;
            importedLineRenderer.startColor = Color.white;
            importedLineRenderer.endColor = Color.white;
            transformHolder.Add(lineStartingPoint);
            transformHolder.Add(lineEndingPoint);
            importedLineRenderer.SetPositions(transformHolder.ToArray());
            starNext = star2;
            starCount++;
            global.starSpawnerFrameworkScript.StarReset();
        }

    }
    
}
