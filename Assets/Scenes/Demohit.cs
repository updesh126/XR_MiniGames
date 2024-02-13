using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demohit : MonoBehaviour
{
    [SerializeField]
    AudioSource HitAudio;
    [SerializeField]
    ParticleSystem _particleSystem;
    private void OnTriggerEnter(Collider other)
    {
        
        Debug.Log("hhiiiiiiii");
        if (other.gameObject.tag == "Right")
        {
            gameObject.SetActive(false);
            Debug.Log("hit by Player");
            HitAudio.Play();
            _particleSystem.Play();
        }
    }
}
