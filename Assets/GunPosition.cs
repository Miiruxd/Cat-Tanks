using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPosition : MonoBehaviour
{ 
    public Vector3 position = new Vector3(10, 5, 0);


    public void Awake()
    {
        //GetComponent<SpriteRenderer>().CT
        transform.position = position;
    }
}
