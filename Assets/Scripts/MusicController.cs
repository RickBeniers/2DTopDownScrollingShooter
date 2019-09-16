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

    // Start is called before the first frame update
    void Start()
    {
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
}
