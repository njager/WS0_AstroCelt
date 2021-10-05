using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawingScript : MonoBehaviour
{
    [Header("Variables")]
    public Transform drawingScriptSelf;
    public Quaternion intitalQuaternion;

    public LineRenderer lineRendererPrefab; 

    private LineRenderer importedLineRenderer;
    private GlobalController global;

    private Transform lineStartingPoint;
    private Transform lineEndingPoint;


    [Header("Positioning")]
    public List<Vector3> transformHolder = new List<Vector3>();

    private Vector3 initialPosition = Vector3.zero;
    private Transform intitalTransform; 

    [Header("Star Reporting")]
    public int activeStarCounter;

    public void Start()
    {
        intitalQuaternion = Quaternion.identity; 
        intitalTransform = drawingScriptSelf.transform;
        global = GlobalController.instance;
    }


    public bool instancedLineRenderer { get { return importedLineRenderer != null; } }

    public void drawLine()
    {
        importedLineRenderer = Instantiate(lineRendererPrefab, initialPosition, intitalQuaternion, intitalTransform);

        importedLineRenderer.startWidth = 0.1f;
        importedLineRenderer.endWidth = 0.1f;
        importedLineRenderer.useWorldSpace = true;
        transformHolder.Add(lineStartingPoint.transform.position);
        transformHolder.Add(lineEndingPoint.position);
        importedLineRenderer.SetPositions(transformHolder.ToArray());

        if (activeStarCounter == 1)
        {
            //LineRenderer.SetPosition(0, global.activeStarList[0].starPosition);
            //LineRenderer.SetPosition(1, TransformTwo.position);
        }
    }
}
