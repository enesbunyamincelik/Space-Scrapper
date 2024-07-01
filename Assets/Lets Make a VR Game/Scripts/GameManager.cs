using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float SkyboxSpeed;

    // Update is called once per frame
    void Update()
    {
        RenderSettings.skybox.SetFloat("Rotation", Time.time * SkyboxSpeed);
    }
}
