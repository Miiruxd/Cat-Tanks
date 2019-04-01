using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileHandler : MonoBehaviour
{
    private GameObject levelManager;
    private GameObject cam;

    void Start()
    {
        cam = GameObject.FindGameObjectWithTag("MainCamera");
    }

    void Update()
    {
        cam.GetComponent<Transform>().SetPositionAndRotation(new Vector3(transform.position.x + 2.3f, cam.transform.position.y, cam.transform.position.z), cam.transform.rotation);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform" || collision.gameObject.tag == "Ground")
        {
            Invoke("Remove", 1.0f);
        }
    }

    void Remove()
    {
        gameObject.SetActive(false);
        levelManager = GameObject.FindGameObjectWithTag("LevelManager");
        levelManager.GetComponent<LevelManager>().TransitionCameraToTheLeft();
    }
}
