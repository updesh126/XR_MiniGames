using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BoxingTimer_1 : MonoBehaviour
{
    public float remainingTime;
    public bool isTimeRunning;

    [SerializeField]
    private GameObject SpwanSystem;
    [SerializeField] GameObject PanelShow;
    [SerializeField] private GameObject ScoreBoad;
    [SerializeField]
    AudioSource TimeOut;

    [SerializeField] private TextMeshProUGUI TimerTxt;

    private void Start()
    {
        isTimeRunning = true;
        remainingTime = PlayerPrefs.GetInt("Boxing1");
    }
    void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
        }
        else if(remainingTime < 0)
        {
            remainingTime = 0;
            TimerTxt.color = Color.red;
            SpwanSystem.SetActive(false);
            PanelShow.SetActive(false);
            ScoreBoad.SetActive(true);
            TimeOut.Play();
        }
        //remainingTime -= Time.deltaTime;
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        //int timer = PlayerPrefs.GetInt("Boxing1");
        TimerTxt.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
