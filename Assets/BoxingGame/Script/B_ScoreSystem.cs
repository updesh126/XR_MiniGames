using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class B_ScoreSystem : MonoBehaviour
{
    [SerializeField] 
    private TMP_Text text;
    public TMP_Text YourScoretext;
    public TMP_Text HighScoretext;
    public TMP_Text Congtext;

    [SerializeField] int addScore = 10, removeScore = 10;

    private int Tscore;

    void Start()
    {
        Tscore = 0;
        HighScoretext.text = PlayerPrefs.GetInt("B_1_HighScore",0).ToString();
    }
    private void Update()
    {
        text.text = Tscore.ToString();
        YourScoretext.text = Tscore.ToString();
        if(Tscore> PlayerPrefs.GetInt("B_1_HighScore",0))
        {
            PlayerPrefs.SetInt("B_1_HighScore", Tscore);
            HighScoretext.text = PlayerPrefs.GetInt("B_1_HighScore", 0).ToString();

            Congtext.gameObject.SetActive(true);
        }
    }

    public void AddScore()
    {
        Tscore += addScore;
    }
    public void RemoveScore()
    {
        Tscore -= removeScore;
    }
}
