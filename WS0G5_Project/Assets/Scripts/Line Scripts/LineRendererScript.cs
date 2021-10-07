using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRendererScript : MonoBehaviour
{
    [Header("Self Reference")]
    public GameObject lineGameObject;

    public LineRenderer selfLine;
    public float LineWidth = 0.5f; 
    private CapsuleCollider capsule;


    public bool lineDrew = true;

    [Header("Capsule Collider")]
    public Vector3 start;
    public Vector3 end;

    public void Start()
    {
        selfLine = lineGameObject.GetComponent<LineRenderer>();
        capsule = lineGameObject.GetComponent<CapsuleCollider>(); 
        capsule.radius = LineWidth / 2;
        capsule.center = Vector3.zero;
        capsule.direction = 2; // Z-axis for easier "LookAt" orientation
    }

    public void Update()
    {
        start = selfLine.GetPosition(0);
        end = selfLine.GetPosition(1);

        capsule.transform.position = start + (end - start) / 2;
        capsule.transform.LookAt(start);
        capsule.height = (end - start).magnitude;
    }

    void OnColliderEnter()
    {
        Debug.Log("Hit!");
        //GameObject other = collision.gameObject; 
        //if (other.CompareTag("Line"))
        //{
        //    if (other != lineGameObject)
       //     {
    //          Debug.Log("Destroying"); 
      //          lineDrew = false;
        //        Destroy(lineGameObject);
       //         return;
         //   }
      //  }
      //  else
     //   {
     //       return; 
    //    }
    }
    public void OnDestroy()
    {
        Debug.Log("Yep Destoryed"); 
    }
}