using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawingScript : MonoBehaviour
{
    [Header("Variables")]
    public LineRenderer lineRendererPrefab;

    private GlobalController global;

    private Vector3 lineStartingPoint;
    private Vector3 lineEndingPoint;

    public Star star1;
    public Star star2; 

    [Header("Positioning")]
    public List<Vector3> transformHolder = new List<Vector3>();

    private Vector3 initialPosition = Vector3.zero;
    public Transform drawingScriptSelf;
    public Quaternion intitalQuaternion;


    [Header("Star Reporting")]
    public int activeStarCounter = 0;

    public void Start()
    {
        lineStartingPoint = Vector3.zero;
        lineStartingPoint = Vector3.zero; 
        intitalQuaternion = Quaternion.identity;
        global = GlobalController.instance;
    }


    // public bool instancedLineRenderer { get { return importedLineRenderer != null; } }

    public void drawLine()
    {
        if (activeStarCounter == 2)
        {
            LineRenderer importedLineRenderer = Instantiate(lineRendererPrefab);
            importedLineRenderer.useWorldSpace = true;
            Debug.Log("Spawned in Line");
            lineStartingPoint = star1.transform.position;
            lineEndingPoint = star2.transform.position;

            importedLineRenderer.startWidth = 0.1f;
            importedLineRenderer.endWidth = 0.1f;
            transformHolder.Add(lineStartingPoint);
            transformHolder.Add(lineEndingPoint);
            importedLineRenderer.SetPositions(transformHolder.ToArray());
        }
        else
        {
            return; 
        }
    }
}
