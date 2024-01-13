using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class B_ScoreSystem : MonoBehaviour
{
    [SerializeField] 
    private TMP_Text text;

    [SerializeField] int addScore = 10, removeScore = 10;

    private int Tscore;

    void Start()
    {
        Tscore = 0;
    }
    private void Update()
    {
        text.text = Tscore.ToString();
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
