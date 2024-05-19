using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using TMPro;
using UnityEngine.SocialPlatforms;

public class R_ScoringSystem : MonoBehaviour
{
    [SerializeField]
    private TMP_Text text;

    [SerializeField] private TMP_Text caption;

    [SerializeField]
    R_OculusPlayerController oculusPlayerController;

    [Header("Top Score")]
    public TMP_Text YourScoretext;
    public TMP_Text HighScoretext;
    //public TMP_Text Congtext;

    static private int Score = 0;


    private void Update()
    {
        text.text = Score.ToString();
        caption.text = Score.ToString();

        if (Score > PlayerPrefs.GetInt("Runner", 0) )
        {
            PlayerPrefs.SetInt("Runner", Score);
            HighScoretext.text = PlayerPrefs.GetInt("Runner", 0).ToString();
            //oculusPlayerController.stop();
            //Congtext.gameObject.SetActive(true);
        }
    }
    public void AddScore(int score)
    {
        Score += score;
    }

    public void Reset()
    {
        Score = 0;
    }
}
