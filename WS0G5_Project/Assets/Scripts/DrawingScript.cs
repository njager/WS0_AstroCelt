using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawingScript : MonoBehaviour
{
    private LineRenderer LineRenderer;
    private GlobalController global;

    void Start()
    {
        global = GlobalController.instance;
    }

    public void drawLine()
    {
        LineRenderer.startWidth = 0.3f;
        LineRenderer.endWidth = 0.3f;

        if (global.lineRenderer.activeStarCounter == 1)
        {
            //LineRenderer.SetPosition(0, global.activeStarList[0].starPosition);
            //LineRenderer.SetPosition(1, TransformTwo.position);
        }
    }
}
