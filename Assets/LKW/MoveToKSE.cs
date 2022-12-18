using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToKSE : MonoBehaviour
{
    public Object SceneToLoad;

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
        SceneManager.LoadScene("Sangeun_Scene");
    }
}