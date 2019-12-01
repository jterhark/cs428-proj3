using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class AmbientChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Change(float f)
    {
        RenderSettings.ambientIntensity = f;
        RenderSettings.reflectionIntensity = f;
        if (f.Equals(0.0f))
        {
            RenderSettings.ambientMode = AmbientMode.Flat;
            RenderSettings.ambientLight = Color.black;
        }
        else
        {
            RenderSettings.ambientMode = AmbientMode.Skybox;
        }
    }
}
