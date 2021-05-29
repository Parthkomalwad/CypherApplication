using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Loadsceen : MonoBehaviour
{
    public void LoadNextScene() {
        SceneManager.LoadScene(1);

    }
    public void LoadFirstScene()
    {
        SceneManager.LoadScene(0);

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
