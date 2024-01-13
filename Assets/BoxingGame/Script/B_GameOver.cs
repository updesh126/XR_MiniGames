using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class B_GameOver : MonoBehaviour
{
    [SerializeField]
    GameObject SpawnManager;
    [SerializeField]
    GameObject GameOverMenu;

    B_cubePunch cube = new B_cubePunch();

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bow")
        {
            SpawnManager.SetActive(false);
            GameOverMenu.SetActive(true);
        }
    }

    public void ResetGame(string Name)
    {
        SceneManager.LoadScene(Name);
        cube.speedReset();
    }
}
