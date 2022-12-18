using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brightness2_scpt : MonoBehaviour
{
    int brightness = 1;
    Renderer MyRenderer;

    void Start()
    {
        MyRenderer = gameObject.GetComponent<Renderer>();
        MyRenderer.material.SetInt("_Brightness", brightness);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        brightness = -1 * brightness;
        MyRenderer.material.SetInt("_Brightness", brightness);
    }
}
