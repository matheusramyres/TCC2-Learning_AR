using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorAudio : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource m_MyAudioSource;
    bool click;



    void Start()
    {
        //Fetch the AudioSource from the GameObject
        m_MyAudioSource = GetComponent<AudioSource>();
        m_MyAudioSource.Stop();
        //Ensure the toggle is set to true for the music to play at start-up
    }

    public void Play(){
        m_MyAudioSource.Play();
    }

    public void Stop(){
        m_MyAudioSource.Stop();
    }
}
