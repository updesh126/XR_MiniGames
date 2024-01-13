using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_ParticalHit : MonoBehaviour
{
    [SerializeField]
    ParticleSystem _particleSystem;
    
    public void PLayHit()
    {
        _particleSystem.Play();
    }
}
