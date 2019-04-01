using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileHandler : MonoBehaviour
{
    private GameObject cam;

    void Start()
    {
        cam = GameObject.FindGameObjectWithTag("MainCamera");
    }

    void Update()
    {
        cam.GetComponent<Transform>().SetPositionAndRotation(new Vector3(transform.position.x + 2.3f, cam.transform.position.y, cam.transform.position.z), cam.transform.rotation);
    }
}
