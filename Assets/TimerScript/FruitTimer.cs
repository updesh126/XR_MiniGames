using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FruitTimer : MonoBehaviour
{
    public float remainingTime;
    public bool isTimeRunning;
    [SerializeField] F_ScoreSystem scoreSystem;
    [SerializeField] private TextMeshProUGUI TimerTxt;
    [Header("GameObjects to Hide")]
    public GameObject System;
    [SerializeField] GameObject PanelShow;
    [SerializeField] private GameObject ScoreBoad;
    [SerializeField]
    AudioSource TimeOut;

    private void Start()
    {
        isTimeRunning = true;
        remainingTime = PlayerPrefs.GetInt("Fruit");
    }
    void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
        }
        else if (remainingTime < 0)
        {
            remainingTime = 0;
            TimerTxt.color = Color.red;
            scoreSystem.ISScored();
            PanelShow.SetActive(false);
            ScoreBoad.SetActive(true);
            System.SetActive(false);
            TimeOut.Play();

        }
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        //int timer = PlayerPrefs.GetInt("Boxing1");
        TimerTxt.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
