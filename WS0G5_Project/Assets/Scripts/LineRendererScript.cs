using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRendererScript : MonoBehaviour
{
    [Header("Self Reference")]
    public LineRenderer LineRenderer;

    public int activeStarCounter;

    void Start()
    {
        LineRenderer.startColor = Color.white;
        LineRenderer.endColor = Color.white;

    }
}
