using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeHandler : MonoBehaviour
{
    public Sprite[] unitsArray;
    private GameObject levelManager;
    public GameObject units;
    private AudioSource audioSrc;
    private float musicVolume = 5f;

    void Start()
    {
        levelManager = GameObject.FindGameObjectWithTag("LevelManager");
        audioSrc = levelManager.GetComponent<AudioSource>();
        audioSrc.volume = musicVolume;
        SetVolume(musicVolume);
    }

    void Update()
    {
        audioSrc.volume = musicVolume;
    }

    public void SetVolume(float vol)
    {
        musicVolume = vol / 10;
        units.GetComponent<SpriteRenderer>().sprite = unitsArray[(int)vol];
    }
}
