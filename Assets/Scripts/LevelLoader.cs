using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// This script load level on mouse click, we will need Scenemanagement package for this
// make sure all the scene levels are in build settings
public class LevelLoader : MonoBehaviour
{
    public int sceneNumber;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
           // LoadLevel();
            ReLoad(); 
        }
        
    }
    void LoadLevel()
    {
       // SceneManager.LoadScene("level2");
       // Method 2 is using build index, visible in the build setting
        SceneManager.LoadScene(sceneNumber);
    }

    // reload the scene, in which we are cuurently in case we loss or exit
    void ReLoad()
    {
       // this will store the build index number from current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
}
