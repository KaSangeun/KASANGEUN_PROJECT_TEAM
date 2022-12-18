using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ui : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string sceneName = gameObject.scene.name;
        print(sceneName);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            SceneManager.LoadScene("UI_scene");
        }
     

    }
    
}

