using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOnBeat : MonoBehaviour
{
    
    public SoundManager _soundManager;
    public AudioClip[] _strum;

    private float startTime;
    private float timePassed;
    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        timePassed = Time.time - startTime;
        if (_strum[0])
        {
            _soundManager.PlaySound(_strum[0], .5f, 0, 0); //, timePassed % (_strum[0].length)
        }
    }
}
