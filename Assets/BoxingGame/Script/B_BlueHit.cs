using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_BlueHit : MonoBehaviour
{

    [SerializeField]
    AudioSource HitAudio;
    [SerializeField]
    B_scoreSyem0 scoreSyem;


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("hhiiiiiiii");
        if (other.gameObject.tag == "Right" || other.gameObject.tag == "Left")
        {
            Debug.Log("hit by Player");
            HitAudio.Play();
            scoreSyem.BlueScoreAdd();
        }
    }
}
