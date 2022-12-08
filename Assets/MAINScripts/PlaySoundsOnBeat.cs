using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundsOnBeat : MonoBehaviour
{
    public SoundManager _soundManager;
    public AudioClip[,] _strum;
    private float startTime;
    private float timePassed;

    int _randomStrum;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        _strum = new AudioClip[4, 4];
    }

    // Update is called once per frame
    void Update()
    {
        timePassed = Time.time - startTime;
        for (int i = 0; i < 4; i++)
        {
            if (_strum[0,i])
            {
                if (BPeerM._beatD8 && (BPeerM._beatCountD8 % 4 == 0))
                {
                    _soundManager.PlaySound(_strum[0, i], 0.5f,0,i);
                }
            }
        }
        for (int j = 0; j < 4; j++)
        {
            if (_strum[1, j])
            {
                if (BPeerM._beatD8 && (BPeerM._beatCountD8 % 4 == 1))
                {
                    _soundManager.PlaySound(_strum[1, j], 0.5f,1,j); 
                }
            }
        }
        for (int k = 0; k < 4; k++)
        {
            if (_strum[2, k])
            {
                if (BPeerM._beatD8 && (BPeerM._beatCountD8 % 4 == 2))
                {
                    _soundManager.PlaySound(_strum[2, k], 0.5f,2,k); 
                }
            }
        }
        for (int l = 0; l < 4; l++)
        {
            if (_strum[3, l])
            {
                if (BPeerM._beatD8 && (BPeerM._beatCountD8 % 4 == 3))
                {
                    _soundManager.PlaySound(_strum[3, l], 0.5f,3,l);
                }
            }
        }
    }
}
