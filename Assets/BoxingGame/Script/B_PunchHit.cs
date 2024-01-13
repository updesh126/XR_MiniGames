using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class B_PunchHit : MonoBehaviour
{
    [Range(0,1)]
    public float intensity;
    public float duration;

    [SerializeField]
    private B_ScoreSystem scoreSystem;

    [SerializeField] private bool R_Hand=false,L_hand = false;

    [SerializeField]
    AudioSource Audio;

    /// <summary>
    /// [SerializeField] private GameObject SpawnerSystem;
    /// </summary>

    //[SerializeField] bool H_Left=false, H_Right=false;

    private void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collider");
        if ( R_Hand==true && other.gameObject.tag == "red")
        {
            other.gameObject.GetComponent<B_ParticalHit>().PLayHit();
            other.gameObject.SetActive(false);
            scoreSystem.AddScore();
            Audio.Play();
        }
        if (L_hand== true && other.gameObject.tag == "blue")
        {
            other.gameObject.GetComponent<B_ParticalHit>().PLayHit();
            other.gameObject.SetActive(false);
            scoreSystem.AddScore();
            Audio.Play();
        }
        if( other.gameObject.tag == "Partical")
        {
            other.gameObject.GetComponent<ParticleSystem>().Play();
        }
        
    }

    public void TriggerHaptic( XRBaseController controller)
    {
        if (intensity > 0)
            controller.SendHapticImpulse(intensity, duration);
    }

}
