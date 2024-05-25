using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;


public class R_OculusPlayerController : MonoBehaviour
{
    public Transform VRPlayer;

    public AudioSource CoinMusic;

    public float lookDoownAngle = 15.0f;

    public float speed = 3.0f;

    public bool isPlaying = false;
    CharacterController characterController;

    [SerializeField]
    GameObject GameOverUI;
    bool isCollied = false;

    public R_SpawnManager spawnManager;
    private R_ScoringSystem scoringSystem;

    private void Start()
    {
        speed = 0f;
        scoringSystem = new R_ScoringSystem();
        characterController = GetComponent<CharacterController>();
    }
    private void Update()
    {
        if(VRPlayer.eulerAngles.x < lookDoownAngle && VRPlayer.eulerAngles.x < 120.0f) {
            isPlaying = true;
        }
        else
        {
            isPlaying = false;
        }

        if (isPlaying == true)
        {
            Vector3 foward = VRPlayer.TransformDirection(Vector3.forward);
            characterController.SimpleMove(foward * speed);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hello");
        if (other.gameObject.CompareTag("Wall"))
        {
            Debug.Log("Collid");
            spawnManager.spawnTriggerEntered();
        }
        if (other.gameObject.tag == "Box" && isCollied == false)
        {
            GameOver();
            isCollied = true;
        }
        if (other.gameObject.tag == "Coin")
        {
            Destroy(other.gameObject);
            scoringSystem.AddScore(1);
            CoinMusic.Play();
            Debug.Log("Coin");
        }
        //if (other.gameObject.tag == "SpawnTrigger")
        
        if(other.gameObject.tag == "resetGame")
        {
            ResetGame("R_Level 1");
        }


    }

    public void StartPlayer(float PlayerSpeed)
    {
        speed = PlayerSpeed;
    }

    private void OnTriggerExit(Collider other)
    {
        isCollied = false;
    }

    private void GameOver()
    {
        speed = 0f;
        GameOverUI.SetActive(true);
    }
    public void ResetGame(string name)
    {
        scoringSystem.Reset();
        SceneManager.LoadScene(name);
    }
    public void stop()
    {
        speed = 0f;
    }

}
