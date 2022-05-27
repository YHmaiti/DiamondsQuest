using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyBoxMVT : MonoBehaviour
{

    public float rotationSp = 1.2f;

    // Update is called once per frame
    void Update()
    {

        // I want to make the sky figure be dynamic and moving instead of just stagnant 
        // update the rotation component of the skybox
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * rotationSp);
    }
}
