using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_PuchByNPC : MonoBehaviour
{

    [SerializeField]
    AudioSource HitAudio;

    B_scoreSyem0 scoreSyem = new B_scoreSyem0();

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("hhiiiiiiii");
        if(other.gameObject.tag == "NPC")
        {
            Debug.Log("hit by npc");
            HitAudio.Play();
            scoreSyem.RedScoreAdd();
        }
    }
}
