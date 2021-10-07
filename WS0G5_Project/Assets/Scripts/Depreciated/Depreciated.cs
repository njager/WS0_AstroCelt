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

    public void drawLine(GameObject constellationLine, Vector3 initialPosition, Vector3 finalPosition) // Grabbed online, may be better 
    {
        var distance = 0f;
        Vector3 centerPos = (initialPosition + finalPosition) / 2f;

        constellationLine.transform.position = centerPos;

        Vector3 direction = finalPosition - initialPosition;
        direction = Vector3.Normalize(direction);
        constellationLine.transform.right = direction;

        distance = Vector3.Distance(initialPosition, finalPosition);

        Debug.DrawLine(initialPosition, finalPosition);

        constellationLine.GetComponent<RectTransform>().sizeDelta = new Vector3(distance, 40f);
    }
}
