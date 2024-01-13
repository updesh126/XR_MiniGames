using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class F_skyboxRotator : MonoBehaviour
{
    public float rotationSpeed = 1.0f;

    void Update()
    {
        // Rotate the skybox based on Time.deltaTime
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * rotationSpeed);
    }
}
