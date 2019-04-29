using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHandler : MonoBehaviour
{
    public Sprite deadSprite;
    Animator anim;
    public GameObject levelManager;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Projectile")
        {
            anim.Play("enemyGiggle", 0);
            collision.gameObject.SetActive(false);
            Invoke("Die", 2.0f);
        }

        if (collision.gameObject.tag == "Spike")
        {
            //anim.Play("enemyGiggle", 0);
            Invoke("Die", 0);
        }
    }

    void Die()
    {
        GetComponent<SpriteRenderer>().sprite = deadSprite;
        Invoke("Remove", 1.0f);
    }

    void Remove()
    {
        gameObject.SetActive(false);
        levelManager.GetComponent<LevelManager>().TransitionCameraToTheLeft();
    }

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {

    }
}