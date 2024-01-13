using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class F_SceneLoader : MonoBehaviour
{
    public void LoadScene(string Name)
    {
        SceneManager.LoadScene(Name);
    }
}
