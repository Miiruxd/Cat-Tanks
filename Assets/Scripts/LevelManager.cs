using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject pauseMenu;
    internal bool isGamePaused;

    void Start()
    {
        isGamePaused = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 1.0f)
            {
                isGamePaused = true;
                Time.timeScale = 0.0f;
                pauseMenu.SetActive(true);
            }
            else
                HidePauseMenu();
        }
    }

    public void HidePauseMenu()
    {
        isGamePaused = false;
        Time.timeScale = 1.0f;
        pauseMenu.SetActive(false);
    }
}
