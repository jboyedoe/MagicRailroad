using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class CollideWithSeq : MonoBehaviour
{
    private int sequenceNum;
    public PlaySoundsOnBeat play;
    private AudioClip f;
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "SequencePad")
        {
            sequenceNum = int.Parse(other.gameObject.name);
            f = this.gameObject.GetComponent<AudioSource>().clip;
            double secondNum = sequenceNum / 4;
            secondNum = (int)Math.Floor(secondNum);
            play._strum[sequenceNum % 4, (int)secondNum] = f;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        sequenceNum = int.Parse(other.gameObject.name);
        double secondNum = sequenceNum / 4;
        secondNum = (int)Math.Floor(secondNum);
        play._strum[sequenceNum % 4, (int) secondNum] = null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
