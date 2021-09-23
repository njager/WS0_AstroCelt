using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GlobalController : MonoBehaviour
{
    public static GlobalController instance; // Making Global into the base for inter-script structure. 

    [Header("Test Int")]
    public int testVar = 50;

    [Header("LineRenderer")]
    public LineRenderer lineRenderer;
    public bool lineDrawn;

    [Header("Audio")]
    public GameObject testAudioBackgroundMusic;
    public GameObject testAudiosoundEffect1;

    [Header("Lists")]
    public GameObject[] starlist;

    [Header("Checkers")]
    public GameObject ResetChecker;

    [Header("Tags")]
    public string starTag = "Star";

    void Start()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse was clicked!");
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            RaycastHit2D objectHit = Physics2D.Raycast(mousePos2D, Vector2.zero); 
            if (objectHit.collider != null)
            {

            }
        }
    }

    void Starlister()
    {
        starlist = GameObject.FindGameObjectsWithTag(starTag);
    }

    public void Update()
    {
        Starlister(); 
    }
}
