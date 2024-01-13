using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_startgame : MonoBehaviour
{
    [SerializeField]
    GameObject PanelHide;
    [SerializeField] GameObject PanelShow;

    [SerializeField]
    Animator Bot;
    [SerializeField]
    AudioSource StartGame;

    [SerializeField]
    EnemyController EnemyController;

    [SerializeField] private bool Right_H = false, Left_H = false;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("YES");
        
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
        if (Right_H == true && Left_H ==true)
        {
            Debug.Log("Final done");
            Bot.enabled = true;
            EnemyController.enabled = true;
            StartGame.Play();
            PanelHide.SetActive(false);
            PanelShow.SetActive(true);
        }

    }
}
