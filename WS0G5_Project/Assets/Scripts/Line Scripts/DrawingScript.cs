using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawingScript : MonoBehaviour
{
    [Header("Variables")]
    public GameObject lineRendererPrefab; 

    private LineRenderer importedLineRenderer;
    private GlobalController global;

    void Start()
    {
        global = GlobalController.instance;
    }


    public bool instancedLineRenderer { get { return importedLineRenderer != null; } }

    public void drawLine()
    {
        importedLineRenderer.startWidth = 0.3f;
        importedLineRenderer.endWidth = 0.3f;

        if (global.lineRenderer.activeStarCounter == 1)
        {
            //LineRenderer.SetPosition(0, global.activeStarList[0].starPosition);
            //LineRenderer.SetPosition(1, TransformTwo.position);
        }
    }
}
