using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_HitPlayer : MonoBehaviour
{
    public AudioSource Punch;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("bot"))
        {
            Punch.Play();
        }
        
    }
}
