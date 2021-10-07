using System;
using System.Runtime.CompilerServices;
using System.Net;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstellatonHolder : MonoBehaviour
{
    public GameObject currentConstellation; 

    public GameObject[] constellationUsed;

    private GlobalController global; 

    public void start()
    {
        global = GlobalController.instance;
    }
}
