using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F_startGame : MonoBehaviour
{
    [SerializeField]
    private GameObject SpwanManager;

    [SerializeField] private GameObject HideCanvas, UnhideCanvas;


    [SerializeField]
    private AudioSource audio;

    private bool Right_H, Left_H;
    // Start is called before the first frame update
    void Start()
    {
        Right_H=false; Left_H=false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Right") { 
            Right_H = true;
        }
        if (other.gameObject.tag == "Left")
        {
            Left_H = true;
        }
        if(Right_H == true && Left_H == true)
        {
            SpwanManager.SetActive(true);
            HideCanvas.SetActive(false);
            UnhideCanvas.SetActive(true);
            audio.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Right")
        {
            Right_H = false;
        }
        if (other.gameObject.tag == "Left")
        {
            Left_H = false;
        }
    }
}
