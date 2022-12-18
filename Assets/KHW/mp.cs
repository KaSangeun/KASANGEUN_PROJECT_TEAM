using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mp : MonoBehaviour
{
    Material myMaterial;
    Shader myShader;
    int pass = 0;
        // Start is called before the first frame update
    void Start()
    {
        myShader = Shader.Find("My/PostEffects/MultiPass");
        myMaterial = new Material(myShader);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            pass = 1 - pass;
        }
        
    }
    public void OnClick_ChangePass()
    {
        pass = 1 - pass;
    }
    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, myMaterial, pass);
    }

    private void OnDisable()
    {
        if (myMaterial)
        {
            DestroyImmediate(myMaterial);
        }
    }

}
