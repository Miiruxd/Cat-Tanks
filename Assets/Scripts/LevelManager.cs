using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject camera;
    internal bool isGamePaused;

    void Start()
    {
        isGamePaused = false;
        InvokeRepeating("MoveCamera", 2.0f, 0.001f);
    }

    void MoveCamera()
    {
        if (camera.transform.position.x > -6)
            camera.GetComponent<Transform>().SetPositionAndRotation(new Vector3(camera.transform.position.x - 0.1f, camera.transform.position.y, camera.transform.position.z), camera.transform.rotation);
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

    public void InitializeMainMenu()
    {
        HidePauseMenu();
        SceneManager.UnloadSceneAsync(1);
        SceneManager.LoadScene(0);
    }

    public void HidePauseMenu()
    {
        isGamePaused = false;
        Time.timeScale = 1.0f;
        pauseMenu.SetActive(false);
    }
}
