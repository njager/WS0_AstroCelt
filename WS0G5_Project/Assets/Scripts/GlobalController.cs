using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    void Start()
    {
        
    }

    public void Update()
    {
        
    }
}
