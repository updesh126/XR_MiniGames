using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerSystem : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI TimerTxt;

    public enum Gametype { isBoxing1,isBoxing2, isFruit, isRunner }
    [SerializeField] Gametype gametype;

    int timerCount = 0;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        TimerTxt.text = timerCount.ToString();  

    }

    public void AddTime()
    {
        if (timerCount >=0)
            timerCount++;
    }
    public void SubTime()
    {
        if (timerCount >0) timerCount--;
    }

    public void SetGame(string name)
    {
        if(gametype == Gametype.isBoxing1)
        {
            PlayerPrefs.SetInt("Boxing1", timerCount*60);
            SceneManager.LoadScene(name);
        }
        if (gametype == Gametype.isBoxing2)
        {
            PlayerPrefs.SetInt("Boxing2", timerCount*60);
            SceneManager.LoadScene(name);
        }
        if (gametype == Gametype.isFruit)
        {
            PlayerPrefs.SetInt("Fruit", timerCount * 60);
            SceneManager.LoadScene(name);
        }
        if (gametype == Gametype.isRunner)
        {
            PlayerPrefs.SetInt("Runner", timerCount * 60);
            SceneManager.LoadScene(name);
        }
    }

}
