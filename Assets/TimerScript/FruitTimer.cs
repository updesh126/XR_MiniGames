using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FruitTimer : MonoBehaviour
{
    public float remainingTime;
    public bool isTimeRunning;

    [SerializeField] private TextMeshProUGUI TimerTxt;

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

        }
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        //int timer = PlayerPrefs.GetInt("Boxing1");
        TimerTxt.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
