using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsManager : MonoBehaviour
{
    public void InitializeFirstLevel()
    {
        SceneManager.UnloadSceneAsync(3);
        SceneManager.LoadScene(1);
    }

    public void InitializeSecondLevel()
    {
        SceneManager.UnloadSceneAsync(3);
        SceneManager.LoadScene(2);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void InitializeLevelSelect()
    {
        SceneManager.UnloadSceneAsync(0);
        SceneManager.LoadScene(3);
    }
}
