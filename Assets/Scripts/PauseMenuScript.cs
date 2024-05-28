using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
using System;

public class PauseMenuScript : MonoBehaviour
{
    [SerializeField] GameObject pauseMenuScreen;

    public GameObject buttons;

    public void PauseGame()
    {
        Time.timeScale = 0;
        pauseMenuScreen.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        pauseMenuScreen.SetActive(false);
    }

    public void ReloadGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level Selection"); // this needs a recheck
    }

    // Master Volume, Music Volume, SFX Volume


    public void GoToMenu()
    {
        SceneManager.LoadScene("Assets/Scenes/PauseScene.unity");
    }
}
