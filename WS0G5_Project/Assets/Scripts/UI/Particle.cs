using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{
    public ParticleClass myInfo;
    public GameObject myPrefab;

    void Start()
    {
        myPrefab = myInfo.myPrefab;
    }
}
