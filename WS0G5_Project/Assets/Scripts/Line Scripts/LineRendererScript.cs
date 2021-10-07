using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRendererScript : MonoBehaviour
{
    [Header("Self Reference")]
    public GameObject lineGameObject;

    public LineRenderer selfLine;
    [SerializeField] float LineWidth = 0.5f; 
    private CapsuleCollider capsule;


    public bool lineDrew = true; // Being checked in drawScript to see if line can draw
    public bool isLinePlaced; // Bool, set in drawing script, so that the lines that are placed and valid don't destroy upon collision 
    private bool lineStateChange; // Use bool to holder the opposite of is line placed to then change it to that

    [Header("Capsule Collider")]
    public Vector3 start;
    public Vector3 end;

    public float offset; // Change capsule collider so that lines can touch inside stars

    public void Start()
    {
        offset = 0.85f;
        isLinePlaced = false; 
        selfLine = lineGameObject.GetComponent<LineRenderer>();
        capsule = lineGameObject.GetComponent<CapsuleCollider>(); 
        capsule.radius = LineWidth / 2;
        capsule.center = Vector3.zero;
        capsule.direction = 2; // Z-axis for easier "LookAt" orientation
    }
    
    public void ToggleBool() //So DrawScript can change the bool inside the script
    {
        if (isLinePlaced != !isLinePlaced)
        {
            lineStateChange = !isLinePlaced;
            isLinePlaced = lineStateChange;
            Debug.Log(isLinePlaced); 
            return; 
        }
    }

    public void Update()
    {
        start = selfLine.GetPosition(0);
        end = selfLine.GetPosition(1);

        capsule.transform.position = start + (end - start) / 2;
        capsule.transform.LookAt(start);
        capsule.height = ((end - start)*offset).magnitude;
    }

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("Hit!");
        GameObject other = col.gameObject; 
        if (other.CompareTag("Line"))
        {
           if(other != lineGameObject)
           {
                if (isLinePlaced == false)
                {
                    Debug.Log("Destroying");
                    lineDrew = false;
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