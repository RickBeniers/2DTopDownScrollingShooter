using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    [SerializeField]
    private bool mcExists;
    [SerializeField]
    private AudioSource[] musicTracks;
    [SerializeField]
    private int currentTrack;
    [SerializeField]
    private bool musicCanPlay;

    public AudioClip soundEffect01;
    public AudioClip soundEffect02;
    public AudioClip soundEffect03;
    public AudioClip soundEffect04;
    public AudioClip soundEffect05;
    public AudioClip soundEffect06;
    public AudioClip soundEffect07;
    public AudioClip soundEffect08;
    public AudioClip soundEffect09;
    public AudioClip soundEffect10;
    public AudioSource MusicSource;

    // Start is called before the first frame update
    void Start()
    {
        MusicSource.clip = soundEffect01;

        if (!mcExists)
        {
            mcExists = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (musicCanPlay)
        {
            if (!musicTracks[currentTrack].isPlaying)
            {
                musicTracks[currentTrack].Play();
            }
        }
        else
        {
            //musicTracks[currentTrack].Stop();
        }
    }
    public void soundEffectController(int musicKey)
    {
        if (musicKey == 1)
        {
            MusicSource.clip = soundEffect01;
            MusicSource.Play();
        }
        else if(musicKey == -1)
        {
            MusicSource.Stop();
        }
        if (musicKey == 2)
        {
            MusicSource.clip = soundEffect02;
            MusicSource.Play();
        }
        else if (musicKey == -2)
        {
            MusicSource.Stop();
        }
        if (musicKey == 3)
        {
            MusicSource.clip = soundEffect03;
            MusicSource.Play();
        }
        else if (musicKey == -3)
        {
            MusicSource.Stop();
        }
        if (musicKey == 4)
        {
            MusicSource.clip = soundEffect04;
            MusicSource.Play();
        }
        else if (musicKey == -4)
        {
            MusicSource.Stop();
        }
        if (musicKey == 5)
        {
            MusicSource.clip = soundEffect05;
            MusicSource.Play();
        }
        else if (musicKey == -5)
        {
            MusicSource.Stop();
        }
        if (musicKey == 6)
        {
            MusicSource.clip = soundEffect06;
            MusicSource.Play();
        }
        else if (musicKey == -6)
        {
            MusicSource.Stop();
        }
        if (musicKey == 7)
        {
            MusicSource.clip = soundEffect07;
            MusicSource.Play();
        }
        else if (musicKey == -7)
        {
            MusicSource.Stop();
        }
        if (musicKey == 8)
        {
            MusicSource.clip = soundEffect08;
            MusicSource.Play();
        }
        else if (musicKey == -8)
        {
            MusicSource.Stop();
        }
        if (musicKey == 9)
        {
            MusicSource.clip = soundEffect09;
            MusicSource.Play();
        }
        else if (musicKey == -9)
        {
            MusicSource.Stop();
        }
        if (musicKey == 10)
        {
            MusicSource.clip = soundEffect10;
            MusicSource.Play();
        }
        else if (musicKey == -10)
        {
            MusicSource.Stop();
        }
    }
}
