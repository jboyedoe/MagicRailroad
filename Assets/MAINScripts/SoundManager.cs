using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public int _bankSize = 4;
    public AudioSource[,] _soundClip;
    // Start is called before the first frame update
    void Start()
    {
        _soundClip = new AudioSource[4,4];
      
        for (int i=0; i<4; i++)
        { 
            for (int j = 0; j < 4; j++)
            {
                GameObject soundInstance = new GameObject("sound");
                soundInstance.AddComponent<AudioSource>();
                soundInstance.transform.parent = this.transform;
                _soundClip[i, j] = soundInstance.GetComponent<AudioSource>();
            }
        }
    }

    public void PlaySound(AudioClip clip, float volume, int first, int second) //, float time
    {
        if (!_soundClip[first,second].isPlaying)
        {
            _soundClip[first,second].clip = clip;
            _soundClip[first, second].volume = volume;
            _soundClip[first, second].Play();
            return;
        }

        

        GameObject soundInstance = new GameObject("sound");
        soundInstance.AddComponent<AudioSource>();
        soundInstance.transform.parent = this.transform;
        soundInstance.GetComponent<AudioSource>().clip = clip;
        soundInstance.GetComponent<AudioSource>().volume = volume;
        soundInstance.GetComponent<AudioSource>().Play();
        _soundClip[first, second] = (soundInstance.GetComponent<AudioSource>());
           
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
