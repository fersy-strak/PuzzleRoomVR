using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicControl : MonoBehaviour
{
    //static bool isMusicOn = true;
    public GameObject musicSource;
    AudioSource audioSource;

    public void musicOnOff()
    {
        audioSource = musicSource.GetComponent<AudioSource>();

        if (audioSource.isPlaying)
            audioSource.Pause();
        else
            audioSource.Play();

        //musicSource.SetActive(!isMusicOn);
        //isMusicOn = !isMusicOn;
    }

    void OnStart()
    {
        
    }

}
