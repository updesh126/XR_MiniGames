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

    private void Start()
    {
        RedScore = 0;
        BlueScore = 0;
    }

    private void Update()
    {
        Redtext.text = RedScore.ToString();
        Bluetext.text = BlueScore.ToString();
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
