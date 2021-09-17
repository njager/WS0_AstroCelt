using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalController : MonoBehaviour
{
    public static GlobalController instance; // Making Global into the base for inter-script structure. 

    [Header("Test Int")]
    public int testVar = 50;
    void Start()
    {
        
    }

    public void Update()
    {
        
    }
}
