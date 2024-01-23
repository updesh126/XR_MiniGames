using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BoxingTimer_2 : MonoBehaviour
{
    public float remainingTime;
    public bool isTimeRunning;
    public GameObject Enemy;

    [SerializeField] private TextMeshProUGUI TimerTxt;

    [SerializeField] GameObject PanelShow;
    [SerializeField] private GameObject ScoreBoad;
    [SerializeField]
    AudioSource TimeOut;

    private void Start()
    {
        isTimeRunning = true;
        remainingTime = PlayerPrefs.GetInt("Boxing2");
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
            PanelShow.SetActive(false);
            ScoreBoad.SetActive(true);
            Enemy.SetActive(false);
            TimeOut.Play();

        }
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        //int timer = PlayerPrefs.GetInt("Boxing1");
        TimerTxt.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
