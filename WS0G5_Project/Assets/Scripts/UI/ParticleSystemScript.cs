using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystemScript : MonoBehaviour
{
    public GameObject starSpawnEffectPrefab; 

    public void SpawnStarParticleEffect(Transform transform)
    {
        Instantiate(starSpawnEffectPrefab, transform);
    } 
}
