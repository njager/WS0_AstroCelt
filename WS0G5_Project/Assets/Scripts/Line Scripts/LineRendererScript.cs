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
    [SerializeField] int myCount; // Use a count varaible to only toggle once
    

    private Star initialStar;
    private Star finalStar; 

    public bool lineDrew = true; // Being checked in drawScript to see if line can draw
    public bool isLinePlaced; // Bool, set in drawing script, so that the lines that are placed and valid don't destroy upon collision 
    private bool lineStateChange1; // Use bool to holder the opposite of is line placed to then change it to that
    private bool lineStateChange2;
    private bool linePlaced; 

    [Header("Capsule Collider")]
    public Vector3 start;
    public Vector3 end;

    public float offset; // Change capsule collider so that lines can touch inside stars

    private GlobalController global;

    public void Awake()
    {
        global = GlobalController.instance;
        myCount = increaseCount();
    }

    public int increaseCount()
    {
        StaticVariables.lineCount += 1;
        int _TempCount = global.staticVariablesReference.returnLineCount();
        return _TempCount; 
    }

    public void Start()
    {
        global.lineRendererList.Add(this); // Add itself 
        offset = 0.85f; 
        selfLine = lineGameObject.GetComponent<LineRenderer>();
        capsule = lineGameObject.GetComponent<CapsuleCollider>(); 
        capsule.radius = LineWidth / 2;
        capsule.center = Vector3.zero;
        capsule.direction = 2; // Z-axis for easier "LookAt" orientation
    }

    public void setStars(Star star1, Star star2) // Grab the stars that filled up the line, triggered in DrawScript
    {
        initialStar = star1; 
        finalStar = star2;
    }
    
    public void ResetList() // For Reset Behavior
    {
        Destroy(this);
    }

    private void Update() // Update Loop
    {
        start = selfLine.GetPosition(0);
        end = selfLine.GetPosition(1);

        capsule.transform.position = start + (end - start) / 2;
        capsule.transform.LookAt(start);
        capsule.height = ((end - start)*offset).magnitude;
    }

    public bool getLineDrew() // Trying to get the bool to self report 
    {
        return lineDrew; 
    }

    void OnTriggerEnter(Collider col) // Here it detects the other gameObject
    {
        Debug.Log("Hit!"); // Debug Hit
        GameObject other = col.gameObject; // Col GameObject 
        if (other.CompareTag("Line"))
        {
           if(other != lineGameObject)
            {
                if (myCount < other.GetComponent<LineRendererScript>().myCount)
                {
                    Destroy(col); 
                    Debug.Log("Destroying Other Line");
                    return;
                }
                else
                {
                    Debug.Log("Destroying Self");
                    Destroy(lineGameObject);
                    return;
                }
           }
        }
        if (other.CompareTag("Obstacle")) // Hit an Obstacle, destroy self
        {
            Debug.Log("Destroying Self");
            Destroy(lineGameObject);
            return;
        }
        else
        {
          return; 
        }
    }
    public void OnDestroy()
    {
        global.drawingScript.starNext = initialStar; 
        global.lineRendererList.Remove(this);
        global.constellationBeingBuilt.Remove(initialStar);
        global.constellationBeingBuilt.Remove(finalStar);
        Debug.Log("Line Renderer Destroyed");
        Debug.Log("Stars removed"); 
    }
}

// Keeping as a line to look at later
// global.drawingScript.starNext = other.GetComponent<LineRendererScript>().initialStar;