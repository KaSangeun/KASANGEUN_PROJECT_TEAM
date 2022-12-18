using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c : MonoBehaviour
{
    Shader myShader;        
    Material myMaterial;

    public float brightness = 1.0f;
    public float saturation = 1.0f;
    public float contrast = 1.0f;

    void Start()
    {
        myShader = Shader.Find("My/PostEffects/Color");    
        myMaterial = new Material(myShader);
    }

    private void Update()
    {
        brightness = Mathf.Clamp(brightness, 0.0f, 3.0f);
        saturation = Mathf.Clamp(saturation, 0.0f, 3.0f);
        contrast = Mathf.Clamp(contrast, 0.0f, 3.0f);
    }

    private void OnDisable()
    {
        if (myMaterial)
        {
            DestroyImmediate(myMaterial);
        }
    }

 
}