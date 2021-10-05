using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawingScript : MonoBehaviour
{
    [Header("Variables")]
    public LineRenderer lineRendererPrefab; 

    private LineRenderer importedLineRenderer;
    private GlobalController global;

    private Transform lineStartingPoint;
    private Transform lineEndingPoint;


    [Header("Positioning")]
    public List<Vector3> transformHolder = new List<Vector3>();

    private Vector3 initialPosition = Vector3.zero;
    public Transform drawingScriptSelf;
    public Quaternion intitalQuaternion;


    [Header("Star Reporting")]
    public int activeStarCounter;

    public void Start()
    {
        intitalQuaternion = Quaternion.identity;
        global = GlobalController.instance;
    }


    public bool instancedLineRenderer { get { return importedLineRenderer != null; } }

    public void drawLine()
    {
        if (activeStarCounter == 2)
        {
            importedLineRenderer = Instantiate(lineRendererPrefab, initialPosition, intitalQuaternion, drawingScriptSelf);

            importedLineRenderer.startWidth = 0.1f;
            importedLineRenderer.endWidth = 0.1f;
            importedLineRenderer.useWorldSpace = true;
            transformHolder.Add(lineStartingPoint.transform.position);
            transformHolder.Add(lineEndingPoint.position);
            importedLineRenderer.SetPositions(transformHolder.ToArray());
        }
    }
}
