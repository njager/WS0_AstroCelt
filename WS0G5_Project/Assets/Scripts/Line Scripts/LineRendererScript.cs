using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRendererScript : MonoBehaviour
{
    [Header("Self Reference")]
    public GameObject lineGameObject;

    public LineRenderer selfLine;
    [SerializeField] float LineWidth = 0.5f; // Referencing line Renderer width for capsule collider
    private CapsuleCollider capsule;
    [SerializeField] int boolCount; // Use a count varaible to only toggle once


    public bool lineDrew = true; // Being checked in drawScript to see if line can draw
    public bool isLinePlaced; // Bool, set in drawing script, so that the lines that are placed and valid don't destroy upon collision 
    private bool lineStateChange1; // Use bool to holder the opposite of is line placed to then change it to that
    private bool lineStateChange2;
    private bool linePlaced; 

    [Header("Capsule Collider")]
    public Vector3 start;
    public Vector3 end;

    public float offset; // Change capsule collider so that lines can touch inside stars

    public void Start()
    {
        boolCount = 0; 
        offset = 0.85f; 
        selfLine = lineGameObject.GetComponent<LineRenderer>();
        capsule = lineGameObject.GetComponent<CapsuleCollider>(); 
        capsule.radius = LineWidth / 2;
        capsule.center = Vector3.zero;
        capsule.direction = 2; // Z-axis for easier "LookAt" orientation
    }
    
    public void ToggleBool() //So DrawScript can change the bool inside the script
    {
        if (boolCount == 0)
        {
            if (isLinePlaced != !isLinePlaced)
            {
                Debug.Log("Triggered");
                lineStateChange1 = !isLinePlaced;
                isLinePlaced = lineStateChange1;
                Debug.Log(isLinePlaced);
                return;
            }
        }
        else
        {
            return; 
        }
    }

    public bool getLinePlaced()
    {
        if (linePlaced != true)
        {
            Debug.Log("Triggered linePlaced");
            lineStateChange2 = !isLinePlaced;
            isLinePlaced = lineStateChange2;
            Debug.Log(isLinePlaced);
        }
        return linePlaced; 
    }

    public void Update()
    {
        start = selfLine.GetPosition(0);
        end = selfLine.GetPosition(1);

        capsule.transform.position = start + (end - start) / 2;
        capsule.transform.LookAt(start);
        capsule.height = ((end - start)*offset).magnitude;
    }

    public bool getLineDrew()
    {
        return lineDrew; 
    }

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("Hit!");
        GameObject other = col.gameObject; 
        if (other.CompareTag("Line"))
        {
           if(other != lineGameObject)
           {
                if (linePlaced != false)
                {
                    ToggleBool(); 
                }
                if (isLinePlaced == false)
                {
                    lineDrew = false;
                    Debug.Log("Destroying");
                    Destroy(lineGameObject);
                    return;
                }
                else
                {
                    return; 
                }
           }
        }
        else
        {
          return; 
        }
    }
    public void OnDestroy()
    {
        Debug.Log("Line Renderer Destroyed"); 
    }
}