using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_spawn : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnPoint;
    private GameObject level_manager;

    void Start()
    {
        level_manager = GameObject.Find("Level Manager");
    }

    void FixedUpdate()
    {
        bool shoot = Input.GetButtonDown("Fire1");
        if (shoot && level_manager.GetComponent<LevelManager>().canShoot)
        {
            Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
            level_manager.GetComponent<LevelManager>().canShoot = false;
        }
    }
}
