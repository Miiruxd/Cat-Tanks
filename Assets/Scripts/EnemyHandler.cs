using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHandler : MonoBehaviour
{
    public Sprite deadSprite;
    Animator anim;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Projectile")
        {
            anim.Play("enemyGiggle", 0);
            collision.gameObject.SetActive(false);
            Invoke("Die", 2.0f);
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
    }

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {

    }
}