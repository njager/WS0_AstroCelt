using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRendererScript : MonoBehaviour
{
    [Header("Self Reference")]
    public LineRenderer lineRenderer;

    public bool lineDrew; 

    public void Start()
    {
        lineDrew = true; 
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Line")
        {
            Destroy(this); 
        }
    }
}   

