using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScript : MonoBehaviour
{
    public List<AudioSource> musicPlaylist;
    private int _musicIndex = 0;
    private static MusicScript _musicInstance;

    private void Awake()
    {
        DontDestroyOnLoad(this);

        if (_musicInstance == null)
        {
            _musicInstance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!musicPlaylist[0].isPlaying && !musicPlaylist[1].isPlaying && !musicPlaylist[2].isPlaying &&
            !musicPlaylist[3].isPlaying && !musicPlaylist[4].isPlaying && !musicPlaylist[5].isPlaying)
        {
            musicPlaylist[_musicIndex].Play();
            _musicIndex++;

            if (_musicIndex == 5)
            {
                _musicIndex = 0;
            }
        }
    }
}
