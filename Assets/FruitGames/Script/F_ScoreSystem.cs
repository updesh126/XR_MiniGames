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
    static int AScore = 0;
    static int OScore = 0;
    static int MScore = 0;
    static int TScore = 0;

    [Header("Reward")]
    [SerializeField] private UnityEngine.UI.Image Reward;
    [SerializeField] private Sprite FistMedal;
    [SerializeField] private Sprite SecondMedal;
    [SerializeField] private Sprite ThirdMedal;

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
    void Update()
    {
        TScore = (AScore*4)+(OScore*6)+(MScore*4);
        ScoreTxt.text= TScore.ToString();
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
}
