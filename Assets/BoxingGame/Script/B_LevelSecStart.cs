using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_LevelSecStart : MonoBehaviour
{
    [SerializeField]
    private GameObject SpwanSystem;

    [SerializeField] GameObject PanelHide;
    [SerializeField] GameObject PanelShow;

    [SerializeField]
    AudioSource StartGame;

    [SerializeField] private bool Right_H = false, Left_H = false;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("YES");
        /*if (other.gameObject.tag == "Start")
        {
            Debug.Log("heelo");
            Bot.enabled = true;
        }*/
        if (other.gameObject.tag == "Right")
        {
            Debug.Log("Right done");
            Right_H = true;
        }
        if (other.gameObject.tag == "Left")
        {
            Debug.Log("Left done");
            Left_H = true;
        }
        if (Right_H == true && Left_H == true)
        {
            Debug.Log("Final done");
            SpwanSystem.SetActive(true);
            StartGame.Play();
            PanelHide.SetActive(false); 
            PanelShow.SetActive(true);
        }

    }
}
