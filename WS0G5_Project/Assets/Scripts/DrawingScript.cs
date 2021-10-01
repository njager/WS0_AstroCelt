using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawingScript : MonoBehaviour
{
    public LineRenderer LineRenderer;
    public Transform TransformOne;
    public Transform TransformTwo;

    public int activeStarCounter;

    void Start()
    {
        LineRenderer.startColor = Color.white;
        LineRenderer.endColor = Color.white;

        LineRenderer.startWidth = 0.3f;
        LineRenderer.endWidth = 0.3f;

        LineRenderer.SetPosition(0, TransformOne.position);
        LineRenderer.SetPosition(1, TransformTwo.position);
    }
}
