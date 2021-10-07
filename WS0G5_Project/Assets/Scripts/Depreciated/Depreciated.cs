using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Depreciated : MonoBehaviour
{
    private string starTag;

    void OldRaycastCode()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse was clicked");
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            RaycastHit2D objectHit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (objectHit.collider != null)
            {
                if (objectHit.collider.tag == starTag)
                {
                    Debug.Log("Clicked on Star");

                }
            }
        }
    }
}
