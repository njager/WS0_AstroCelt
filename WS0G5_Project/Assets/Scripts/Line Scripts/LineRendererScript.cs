using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRendererScript : MonoBehaviour
{
    [Header("Self Reference")]
    public LineRenderer lineRenderer;

    public bool lineDrew = true; 

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Line")
        {
            if (collision.gameObject != lineRenderer)
            {
                Debug.Log("Destroying"); 
                lineDrew = false;
                Destroy(this);
                return;
            }
        }
        else
        {
            return; 
        }
    }
}   

