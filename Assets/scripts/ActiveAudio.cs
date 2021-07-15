using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveAudio : MonoBehaviour
{
    AudioSource m_MyAudioSource;
    bool click;



    void Start()
    {
        //Fetch the AudioSource from the GameObject
        m_MyAudioSource = GetComponent<AudioSource>();
        m_MyAudioSource.Stop();
        //Ensure the toggle is set to true for the music to play at start-up
        click = false;
    }

    public void ChangeButton(){
        if(click == true){
            click = false;
            m_MyAudioSource.Stop();
        }
        else{
            click = true;
            m_MyAudioSource.Play();
        }
    }
    
}
