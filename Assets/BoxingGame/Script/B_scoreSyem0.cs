using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class B_scoreSyem0 : MonoBehaviour
{
    [SerializeField]
    private TMP_Text Redtext;

    [SerializeField]
    private TMP_Text Bluetext;

    [SerializeField] static int RedScore, BlueScore;

    public TMP_Text YourScoretext;
    public TMP_Text HighScoretext;
    public TMP_Text Congtext;

    private void Start()
    {
        RedScore = 0;
        BlueScore = 0;
        HighScoretext.text = PlayerPrefs.GetInt("B_1_HighScore", 0).ToString();

    }

    private void Update()
    {
        Redtext.text = RedScore.ToString();
        Bluetext.text = BlueScore.ToString();

        YourScoretext.text = BlueScore.ToString();
        if (BlueScore > PlayerPrefs.GetInt("B_1_HighScore", 0))
        {
            PlayerPrefs.SetInt("B_1_HighScore", BlueScore);
            HighScoretext.text = PlayerPrefs.GetInt("B_1_HighScore", 0).ToString();
            Congtext.gameObject.SetActive(true);
        }
    }

    public void RedScoreAdd()
    {
        RedScore += 1;
        Debug.Log("!!!");
    }
    public void BlueScoreAdd()
    {
        BlueScore += 1;
    }
}
