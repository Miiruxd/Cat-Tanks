using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HandleLevel1 : MonoBehaviour
{
    public GameObject enemy1;
    public GameObject enemy2;

    void Update()
    {
        if (enemy1.activeSelf == false && enemy2.activeSelf == false)
        {
            SceneManager.UnloadSceneAsync(1);
            SceneManager.LoadScene(2);
        }
    }
}
