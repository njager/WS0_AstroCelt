using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawingScript : MonoBehaviour
{
    [Header("Variables")]
    public GameObject lineRendererPrefab; 

    private LineRenderer importedLineRenderer;
    private GlobalController global;

    private Transform lineStartingPoint;
    private Transform lineEndingPoint;

    [Header("Positions Lists")]
    public List<Vector3> transformHolder = new List<Vector3>();

    public void Start()
    {
        global = GlobalController.instance;
    }


    public bool instancedLineRenderer { get { return importedLineRenderer != null; } }

    public void drawLine()
    {
        importedLineRenderer.startWidth = 0.3f;
        importedLineRenderer.endWidth = 0.3f;
        transformHolder.Add(lineStartingPoint.transform.position);
        transformHolder.Add(lineEndingPoint.position);

        if (global.lineRenderer.activeStarCounter == 1)
        {
            //LineRenderer.SetPosition(0, global.activeStarList[0].starPosition);
            //LineRenderer.SetPosition(1, TransformTwo.position);
        }
    }
}
