using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioButton : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioMixer audioMixer;

    public bool playing = false;

    void Start(){
        audioSource = GetComponent<AudioSource>();
        playing = false;
    }

    public void ButtonPress(){
        if(playing)
        {
            audioSource.Stop();
            playing = false;
        }
        else
        {
            audioSource.Play();
            playing = true;
        }
    }

    public void MuteToggle(){
        audioMixer.SetFloat("MasterVolume", -80);
    }

    public void MuteAll(){
        AudioSource[] sources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
         for( int index = 0 ; index < sources.Length ; ++index )
         {
            sources[index].Stop();
         }
     
    }

}
