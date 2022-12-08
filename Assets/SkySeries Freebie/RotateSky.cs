using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSky : MonoBehaviour
{
    public float RotateSpeed = 0.4f;

    void Update() {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * RotateSpeed);
        
    }
}
