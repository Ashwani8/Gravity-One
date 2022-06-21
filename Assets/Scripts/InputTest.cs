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
            // print("space bar is pressed down");
            // change game object color to green when pressed
         GetComponent<Renderer>().material.color = Color.green;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            // print("space key is hold down");
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            // print("space bar is Released");
            // change object color to red after the key is released
            GetComponent<Renderer>().material.color = Color.red;

        }


        // Note that there are some predefined way to access button as explained earlier, like arrow keys
        // for left left/right, up/down, motion and space bar for Jump
       if (Input.GetButtonDown("Jump"))
        { // its CAPITAL J in jump, otherwise it will geive an error
            print("space bar is pressed for jump");
            // i have added rigid body to gameobject and ground for a refrence although not needed here.
            transform.position += new Vector3(0, 1, 0); // jump up by increasing y by one unit.

        }
    } 
}
