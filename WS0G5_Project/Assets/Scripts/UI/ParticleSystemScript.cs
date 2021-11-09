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
        GameObject _particle = Instantiate(damageParticlePrefab, _transform);
        ParticleSystem _system = _particle.GetComponent<ParticleSystem>();
        _system.Play(); 

    }

    public void SpawnHealthParticleEffect(Transform _transform)
    {
        GameObject _particle = Instantiate(healthParticlePrefab, _transform);
        ParticleSystem _system = _particle.GetComponent<ParticleSystem>();
        _system.Play();
    }

    public void SpawnShieldParticleEffect(Transform _transform)
    {
        GameObject _particle = Instantiate(shieldParticlePrefab, _transform);
        ParticleSystem _system = _particle.GetComponent<ParticleSystem>();
        _system.Play();
    }

    public void SpawnStunParticleEffect(Transform _transform)
    {
        GameObject _particle = Instantiate(stunParticlePrefab, _transform);
        ParticleSystem _system = _particle.GetComponent<ParticleSystem>();
        _system.Play();
    }

    public void SpawnBaseStarParticleEffect(Transform _transform)
    {
        GameObject _particle = Instantiate(baseStarParticlePrefab, _transform);
        ParticleSystem _system = _particle.GetComponent<ParticleSystem>();
        _system.Play();
    }

    // Not for being used in a constellation, but for when having clicked on a constellation 
    public void SpawnNodeParticleEffect(Transform _transform)
    {
        GameObject _particle = Instantiate(nodeClickedParticlePrefab, _transform);
        ParticleSystem _system = _particle.GetComponent<ParticleSystem>();
        _system.Play();
    }

    public void SpawnConfirmParticleEffect(Transform _transform)
    {
        GameObject _particle = Instantiate(confirmParticlePrefab, _transform);
        ParticleSystem _system = _particle.GetComponent<ParticleSystem>();
        _system.Play();
    }
}

