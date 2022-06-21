using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// This Script is about the input keys. there are some predefined keys in 
// project settings>Input>axis such as "jump" for space key
public class InputTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // We will check if a specific key is pressed, hold , or released
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("space key is pressed down");
        }

        if (Input.GetKey(KeyCode.Space))
        {
            print("space key is hold down");
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            print("space key is Released");
        }
    }
}
