using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagment : MonoBehaviour
{
    public AudioClip backgroundMusicClip;
    public AudioSource backgroundMusicSource;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        backgroundMusicSource.clip = backgroundMusicClip;
        backgroundMusicSource.Play();

    }
}
