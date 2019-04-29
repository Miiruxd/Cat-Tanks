using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameObject gun;
    public GameObject pauseMenu;
    public GameObject cam;
    public GameObject swapPanel;
    internal bool isGamePaused;
    public bool canShoot;

    private Vector3 cat1Pos = new Vector3(0.5f, 0.62f, 0);
    private Vector3 cat2Pos = new Vector3(0.79f, -0.43f, 0);
    private Vector3 cat3Pos = new Vector3(0.4595337f, -0.1589674f, 0);
    private Vector3 cat4Pos = new Vector3(0.67f, 0.05f, 0);

    void Start()
    {
        isGamePaused = false;
        canShoot = false;
        TransitionCameraToTheLeft();
    }

    public void TransitionCameraToTheLeft()
    {
        InvokeRepeating("MoveCamera", 2.0f, 0.001f);
    }

    void MoveCamera()
    {
        if (cam.transform.position.x > -6)
            cam.GetComponent<Transform>().SetPositionAndRotation(new Vector3(cam.transform.position.x - 0.1f, cam.transform.position.y, cam.transform.position.z), cam.transform.rotation);
        else
        {
            CancelInvoke();
            canShoot = true;
        }
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
            if (swapPanel.activeSelf == true)
                swapPanel.SetActive(false);
        }
        if (Input.GetMouseButton(0))
        {

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

    public void PauseGame()
    {
        isGamePaused = true;
        Time.timeScale = 0.0f;
    }

    public void ResumeGame()
    {
        isGamePaused = false;
        Time.timeScale = 1.0f;
    }

    public void ToggleSwapPanel()
    {
        if (swapPanel.activeSelf)
        {
            swapPanel.SetActive(false);
            ResumeGame();
        }
        else
        {
            swapPanel.SetActive(true);
            PauseGame();
        }
    }

    public void AdjustGunPositionCat1()
    {
        gun.GetComponent<Transform>().localPosition = cat1Pos;
    }

    public void AdjustGunPositionCat2()
    {
        gun.GetComponent<Transform>().localPosition = cat2Pos;
    }

    public void AdjustGunPositionCat3()
    {
        gun.GetComponent<Transform>().localPosition = cat3Pos;
    }

    public void AdjustGunPositionCat4()
    {
        gun.GetComponent<Transform>().localPosition = cat4Pos;
    }
}
