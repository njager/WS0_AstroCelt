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
        Debug.Log("Hit!");
        GameObject other = collision.gameObject; 
        if (other.CompareTag("Line"))
        {
            if (other != lineRenderer)
            {
                Debug.Log("Destroying"); 
                lineDrew = false;
                Destroy(lineRenderer);
                return;
            }
        }
        else
        {
            return; 
        }
    }
    public void OnDestroy()
    {
        Debug.Log("Yep Destoryed"); 
    }
}