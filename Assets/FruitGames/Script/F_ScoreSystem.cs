using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class F_ScoreSystem : MonoBehaviour
{
    [Header("Score System")]

    [SerializeField] private TextMeshProUGUI AppleTxt;
    [SerializeField] private TextMeshProUGUI OrangeTxt;
    [SerializeField] private TextMeshProUGUI MangoTxt;
    [SerializeField] private TextMeshProUGUI ScoreTxt;
    [SerializeField] private TextMeshProUGUI WorngTxt;
    static int AScore = 0;
    static int OScore = 0;
    static int MScore = 0;
    static int TScore = 0;

    [Header("Reward")]
    [SerializeField] private UnityEngine.UI.Image Reward;
    [SerializeField] private Sprite FistMedal;
    [SerializeField] private Sprite SecondMedal;
    [SerializeField] private Sprite ThirdMedal;

    [Header("Top Score")]
    public TMP_Text YourScoretext;
    public TMP_Text HighScoretext;
    public TMP_Text Congtext;
    public bool isScored;

    public void Apple()
    {
        AScore++;
        AppleTxt.text= AScore.ToString();
    }
    public void Orange()
    {
        OScore++;
        OrangeTxt.text= OScore.ToString();
    }
    public void Mango()
    {
        MScore++;
        MangoTxt.text= MScore.ToString();
    }
    private void Start()
    {
        HighScoretext.text = PlayerPrefs.GetInt("Fruit", 0).ToString();
        isScored = false;
    }
    void Update()
    {
        TScore = (AScore*4)+(OScore*6)+(MScore*4);
        ScoreTxt.text= TScore.ToString();
        if (TScore > PlayerPrefs.GetInt("Fruit", 0) && isScored== true)
        {
            PlayerPrefs.SetInt("Fruit", TScore);
            HighScoretext.text = PlayerPrefs.GetInt("Fruit", 0).ToString();

            Congtext.gameObject.SetActive(true);
        }
        ScoreReward();
    }

    private void ScoreReward()
    {
        if (TScore <= 20)
        {
            Reward.sprite = ThirdMedal;
        }
        if(TScore >=30 && TScore <=60 )
        {
            Reward.sprite= SecondMedal;
        }
        if(TScore >= 60)
        {
            Reward.sprite= FistMedal;
        }
    }
    public void WrongFruit(int score, string name)
    {
        TScore -= score;
        WorngTxt .text =  "-"+ score.ToString() +" : "+name;
    }
    public void ISScored()
    {
        isScored = true;
    }
}
