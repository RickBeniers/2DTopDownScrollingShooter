using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectController : MonoBehaviour
{
    public AudioSource effectSource;
    public AudioClip soundEffect01;

    private void Start()
    {
        effectSource.GetComponent<AudioSource>();
    }
    public void soundEffectmanager(int musicKeys)
    {
        switch (musicKeys)
        {
            case 1:
                effectSource.clip = soundEffect01;
                effectSource.Play();
                break;
        }
    }
}
