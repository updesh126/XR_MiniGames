using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RunnerTimer : MonoBehaviour
{
    public R_OculusPlayerController r_OculusPlayerController;
    public float remainingTime;
    public bool isTimeRunning;

    [SerializeField] private TextMeshProUGUI TimerTxt;

    [Header("GameObjects to Hide")]
    [SerializeField] GameObject PanelShow;
    [SerializeField] private GameObject ScoreBoad;
    [SerializeField]
    AudioSource TimeOut;

    private void Start()
    {
        isTimeRunning = true;
        remainingTime = PlayerPrefs.GetInt("Runner");
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
            TimeOut.Play();
            r_OculusPlayerController.stop();
        }
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        //int timer = PlayerPrefs.GetInt("Boxing1");
        TimerTxt.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
