using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static bool GameOver;
    public static bool GameWon;
    public GameObject Helix;

    public GameObject LevelWin;
    public GameObject levelLose;

    private void Start()
    {
        Time.timeScale = 1f;
        GameOver = false;
        GameWon = false;
    }
    void Update()
    {
        if(GameOver)
        {
            Time.timeScale = 1f;
            Helix.GetComponent<HelixRotator>().enabled = false;
            levelLose.SetActive(true);
        }

        if (GameWon)
        {   
            Time.timeScale = 1f;
            Helix.GetComponent<HelixRotator>().enabled = false;
            LevelWin.SetActive(true);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
    }
}
