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
    public LineRenderer lineRendererPrefab;

    private GlobalController global;

    private Vector3 lineStartingPoint;
    private Vector3 lineEndingPoint;

    public Star star1;
    public Star star2; 

    [Header("Position")]
    public List<Vector3> transformHolder = new List<Vector3>();

    [Header("Star Reporting")]
    public int activeStarCounter = 0;
    public List<Star> usedStarList = new List<Star>();

    private Vector3 initialPosition = Vector3.zero;
    public Transform drawingScriptSelf;
    public Quaternion intitalQuaternion;

    public void Start()
    {
        lineStartingPoint = Vector3.zero;
        lineStartingPoint = Vector3.zero;
        global = GlobalController.instance;
    }

    public void update()
    {
        usedStars();
    }


    // public bool instancedLineRenderer { get { return importedLineRenderer != null; } }

    public void drawLine()
    {
        if (activeStarCounter == 1)
        {
            LineRenderer importedLineRenderer = Instantiate(lineRendererPrefab);
            importedLineRenderer.useWorldSpace = true;
            Debug.Log("Spawned in Line");
            usedStarList.Add(star1);
            usedStarList.Add(star2);
            lineStartingPoint = star1.transform.position;
            lineEndingPoint = star2.transform.position;

            importedLineRenderer.startWidth = 0.1f;
            importedLineRenderer.endWidth = 0.1f;
            importedLineRenderer.startColor = Color.white;
            importedLineRenderer.endColor = Color.white;
            transformHolder.Add(lineStartingPoint);
            transformHolder.Add(lineEndingPoint);
            importedLineRenderer.SetPositions(transformHolder.ToArray());
            global.starSpawnerFrameworkScript.StarReset(); 

        }
        else
        {
            return; 
        }
    }
    
    public void usedStars()
    {
        foreach (Star star in usedStarList.ToList())
        {
            star.StarUsed();
        }
    }
}
