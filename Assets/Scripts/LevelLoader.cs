using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// This script load level on mouse click, we will need Scenemanagement package for this
public class LevelLoader : MonoBehaviour
{
    public 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            LoadLevel();
        }
        
    }
    void LoadLevel()
    {
        SceneManager.LoadScene("level2");
    }
}
