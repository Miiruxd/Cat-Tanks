using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Shoot : MonoBehaviour
{
    public float bulletForce = 750.0f;

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.tag == "FirePoint") GetComponent<Rigidbody2D>().AddForce(transform.right * bulletForce);
    }

    void Update()
    {
        var rot = transform.rotation;
        rot.z += -Time.deltaTime * 2 / 5;
        transform.rotation = rot;

    }
}
  