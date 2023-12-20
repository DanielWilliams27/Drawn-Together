using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class GlobalScript : MonoBehaviour
{
    public static KeyCode up = KeyCode.W;
    public static KeyCode down = KeyCode.S;
    public static KeyCode left = KeyCode.A;
    public static KeyCode right = KeyCode.D;

    public static void PlayMusic(AudioSource[] songList)
    {
        foreach (AudioSource song in songList)
        {
            song.Play();
            Thread.Sleep(song.time)
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
