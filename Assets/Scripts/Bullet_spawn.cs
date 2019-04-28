using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_spawn : MonoBehaviour
{
    public GameObject swapButton;
    public GameObject bullet;
    public Transform spawnPoint;
    private GameObject level_manager;
    private SwapCatsButton swapScript;

    void Start()
    {
        level_manager = GameObject.Find("Level Manager");
        swapScript = swapButton.GetComponent<SwapCatsButton>();
    }

    void Update()
    {
        bool shoot = Input.GetButtonDown("Fire1");
        if (shoot && level_manager.GetComponent<LevelManager>().canShoot && !level_manager.GetComponent<LevelManager>().isGamePaused && !swapScript.mouseOverSwapButton)
        {
            Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
            level_manager.GetComponent<LevelManager>().canShoot = false;
        }
    }
}
