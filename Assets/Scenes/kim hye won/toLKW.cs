using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toLKW : MonoBehaviour
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
        
    }
    private void OnMouseDown()
    {
        SceneManager.LoadScene("lkw_scene");
    }
}






    

