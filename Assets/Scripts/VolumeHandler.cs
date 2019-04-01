using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeHandler : MonoBehaviour
{
    private GameObject levelManager;
    private AudioSource audioSrc;
    private float musicVolume = 0.5f;

    void Start()
    {
        levelManager = GameObject.FindGameObjectWithTag("LevelManager");
        audioSrc = levelManager.GetComponent<AudioSource>();
        audioSrc.volume = musicVolume;
    }

    void Update()
    {
        audioSrc.volume = musicVolume;
    }

    public void SetVolume(float vol)
    {
        musicVolume = vol;
    }
}
