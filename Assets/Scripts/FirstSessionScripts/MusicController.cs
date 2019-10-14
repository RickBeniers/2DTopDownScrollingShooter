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
    public AudioSource shootingAudioSource;
    public AudioSource effectSource;

    private GameObject soundManager;

    // Start is called before the first frame update
    void Start()
    {
        soundManager = GameObject.Find("MusicController");
        MusicSource.GetComponent<AudioSource>();
        MusicSource.clip = soundEffect06;

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
    public void explosionSoundController(int musicKey)
    {

        switch (musicKey)
        {
            case 1:
                MusicSource.clip = soundEffect01;
                MusicSource.Play();
                //Debug.Log("play sound 1");
                break;
            case 2:
                MusicSource.clip = soundEffect02;
                MusicSource.Play();
                //Debug.Log("play sound 2");
                break;
            case 3:
                MusicSource.clip = soundEffect03;
                MusicSource.Play();
                //Debug.Log("play sound 3");
                break;
            case 4:
                MusicSource.clip = soundEffect04;
                MusicSource.Play();
                //Debug.Log("play sound 4");
                break;
            case 5:
                MusicSource.clip = soundEffect05;
                MusicSource.Play();
                //Debug.Log("play sound 5");
                break;
            case 6:
                shootingAudioSource.clip = soundEffect06;
                shootingAudioSource.Play();
                //Debug.Log("play sound 6");
                break;
        }
    }
    public void soundEffectsController(int musicKeyss)
    {
        
    } 
}
