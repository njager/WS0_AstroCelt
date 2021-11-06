using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystemScript : MonoBehaviour
{
    public GameObject baseStarParticlePrefab; 
    public GameObject damageParticlePrefab; 
    public GameObject healthParticlePrefab;
    public GameObject nodeClickedParticlePrefab;
    public GameObject shieldParticlePrefab;
    public GameObject stunParticlePrefab; 

    // These can also be used when clicking on the stars
    public void SpawnDamageParticleEffect(Transform transform)
    {
        Instantiate(damageParticlePrefab, transform);
    }

    public void SpawnHealthParticleEffect(Transform transform)
    {
        Instantiate(damageParticlePrefab, transform);
    }

    public void SpawnShieldParticleEffect(Transform transform)
    {
        Instantiate(shieldParticlePrefab, transform);
    }

    public void SpawnStunParticleEffect(Transform transform)
    {
        Instantiate(stunParticlePrefab, transform);
    }

    public void SpawnBaseStarParticleEffect(Transform transform)
    {
        Instantiate(baseStarParticlePrefab, transform);
    }

    // Not for being used in a constellation, but for when having clicked on a constellation 
    public void SpawnNodeParticleEffect(Transform transform)
    {
        Instantiate(nodeClickedParticlePrefab, transform);
    }
}
