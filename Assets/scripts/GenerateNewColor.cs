using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateNewColor : MonoBehaviour
{
    public GameObject color1;
    public GameObject color2;
    public GameObject newColor;
    public GameObject completed_button;
    public GameObject result_audio;
     public GameObject stage_description;
    void OnTriggerEnter(Collider marker)
    {
        if(marker.gameObject.tag == "cor2"){
            color1.SetActive(false);
            color2.SetActive(false);
            stage_description.GetComponent<AudioSource>().Stop();

            if(completed_button != null){
                completed_button.SetActive(true);
            }
            
            newColor.SetActive(true);
            result_audio.GetComponent<AudioSource>().Play();
        }
    }

    void OnTriggerExit(Collider collider)
    {
        color1.SetActive(true);
        color2.SetActive(true);
        if(completed_button != null){
            completed_button.SetActive(false);
        }
        newColor.SetActive(false);
        result_audio.GetComponent<AudioSource>().Stop();
    }

    public void LostMarker(){
        color1.SetActive(true);
        color2.SetActive(true);
        newColor.SetActive(false);
        result_audio.GetComponent<AudioSource>().Stop();
    }
}
