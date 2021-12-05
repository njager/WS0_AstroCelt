using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystemScript : MonoBehaviour
{
    public GameObject baseStarParticlePrefab; 
    public GameObject damageParticlePrefab; 
    public GameObject healthParticlePrefab;
    public GameObject shieldParticlePrefab;
    public GameObject nodeStarClickedParticlePrefab;
    public GameObject accentParticlePrefab;
    public GameObject damageClickPrefab;
    public GameObject healthClickPrefab;
    public GameObject shieldClickPrefab;

    [Header("Demo Particles")]
    public ParticleSystem demoPurple;
    public ParticleSystem demoOrange;

    // These can also be used when clicking on the stars
    public void SpawnDamageParticleEffect(Transform _transform)
    {
        GameObject _particle = Instantiate(damageParticlePrefab, _transform);
        ParticleSystem _system = _particle.GetComponent<ParticleSystem>();
        _system.Play();
        return;
    }

    public void SpawnDamageClickEffect(Transform _transform)
    {
        GameObject _particle = Instantiate(damageClickPrefab, _transform);
        ParticleSystem _system = _particle.GetComponent<ParticleSystem>();
        _system.Play();
        return;
    }

    public void SpawnHealthParticleEffect(Transform _transform)
    {
        GameObject _particle = Instantiate(healthParticlePrefab, _transform);
        ParticleSystem _system = _particle.GetComponent<ParticleSystem>();
        _system.Play();
        return;
    }

    public void SpawnHealthClickEffect(Transform _transform)
    {
        GameObject _particle = Instantiate(healthClickPrefab, _transform);
        ParticleSystem _system = _particle.GetComponent<ParticleSystem>();
        _system.Play();
        return;
    }

    public void SpawnShieldParticleEffect(Transform _transform)
    {
        GameObject _particle = Instantiate(shieldParticlePrefab, _transform);
        ParticleSystem _system = _particle.GetComponent<ParticleSystem>();
        _system.Play();
        return;
    }

    public void SpawnShieldClickEffect(Transform _transform)
    {
        GameObject _particle = Instantiate(shieldClickPrefab, _transform);
        ParticleSystem _system = _particle.GetComponent<ParticleSystem>();
        _system.Play();
        return;
    }

    public void SpawnBaseStarParticleEffect(Transform _transform)
    {
        GameObject _particle = Instantiate(baseStarParticlePrefab, _transform);
        ParticleSystem _system = _particle.GetComponent<ParticleSystem>();
        //GameObject _particle2 = Instantiate(accentParticlePrefab, _transform);
        //ParticleSystem _system2 = _particle2.GetComponent<ParticleSystem>();
        _system.Play();
        //_system2.Play();
        return;
    }

    // Not for being used in a constellation, but for when having clicked on a constellation 
    public void SpawnNodeParticleEffect(Transform _transform)
    {
        GameObject _particle = Instantiate(nodeStarClickedParticlePrefab, _transform);
        ParticleSystem _system = _particle.GetComponent<ParticleSystem>();
        _system.Play();
        return;
    }

    public void SpawnConfirmParticleEffect(Transform _transform)
    {
        GameObject _particle = Instantiate(baseStarParticlePrefab, _transform);
        ParticleSystem _system = _particle.GetComponent<ParticleSystem>();
        GameObject _particle2 = Instantiate(accentParticlePrefab, _transform);
        ParticleSystem _system2 = _particle2.GetComponent<ParticleSystem>();
        GameObject _particle3 = Instantiate(accentParticlePrefab, _transform);
        ParticleSystem _system3 = _particle3.GetComponent<ParticleSystem>();
        _system.Play();
        _system2.Play();
        _system3.Play();
        return;
    }

    public void DemoParticleEffect()
    {
        demoOrange.Play();
        demoPurple.Play();
    }
}

