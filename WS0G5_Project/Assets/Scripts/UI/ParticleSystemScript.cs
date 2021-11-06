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
    public GameObject confirmParticlePrefab;

    // These can also be used when clicking on the stars
    public void SpawnDamageParticleEffect(Transform _transform)
    {
        Instantiate(damageParticlePrefab, _transform);
    }

    public void SpawnHealthParticleEffect(Transform _transform)
    {
        Instantiate(damageParticlePrefab, _transform);
    }

    public void SpawnShieldParticleEffect(Transform _transform)
    {
        Instantiate(shieldParticlePrefab, _transform);
    }

    public void SpawnStunParticleEffect(Transform _transform)
    {
        Instantiate(stunParticlePrefab, _transform);
    }

    public void SpawnBaseStarParticleEffect(Transform _transform)
    {
        Instantiate(baseStarParticlePrefab, _transform);
    }

    // Not for being used in a constellation, but for when having clicked on a constellation 
    public void SpawnNodeParticleEffect(Transform _transform)
    {
        Instantiate(nodeClickedParticlePrefab, _transform);
    }

    public void SpawnConfirmParticleEffect(Transform _transform)
    {
        Instantiate(nodeClickedParticlePrefab, _transform);
    }
}

