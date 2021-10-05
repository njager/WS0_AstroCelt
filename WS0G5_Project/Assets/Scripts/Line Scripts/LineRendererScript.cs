using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRendererScript : MonoBehaviour
{
    [Header("Self Reference")]
    public LineRenderer lineRenderer;

    [Header("Two Points for Line to Draw")]
    //public GameObject object1;
    //public GameObject object2;

    [Header("Positions Lists")]
    public List<Vector3> pos = new List<Vector3>();
   
    public void Awake()
    {
        lineRenderer.GetComponentInParent<Transform>(); 
    }
}
