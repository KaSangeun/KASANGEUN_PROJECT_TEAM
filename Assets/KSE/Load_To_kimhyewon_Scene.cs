using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_To_kimhyewon_Scene : MonoBehaviour
{
    public Object SceneToLoad;

    void Start()
    {
        string sceneName = gameObject.scene.name;
        print(sceneName);
    }

    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        SceneManager.LoadScene("kimhyewon");
    }
}
