using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveAudio : MonoBehaviour
{
    AudioSource m_MyAudioSource;
    bool click;



    void Start()
    {
        m_MyAudioSource = GetComponent<AudioSource>();
        m_MyAudioSource.Play();
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
