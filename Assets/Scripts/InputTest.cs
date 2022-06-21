using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// This Script is about the input keys. there are some predefined keys in 
// project settings>Input>axis such as "jump" for space key
public class InputTest : MonoBehaviour
{

   public float speed = 1;

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
        // Use GetAxis for Smooth motion instead of Key, left/Right arrow "Horizontal"/"Vertical" motion 
        // will go smoothly from 0 to -1 or +1 value
        float xInput = Input.GetAxis("Horizontal"); // we are storin 
        float yInput = Input.GetAxis("Vertical");
        // we are using delta time to change x positon per second rather than frame speed time as different
        // system may have different frame update speed
        xInput = xInput * speed * Time.deltaTime;
        yInput = yInput * speed * Time.deltaTime;
        // Use Get Axis for Smooth motion, from 0 to 1
        //print(xInput);
        //print(yInput);
        // will move object with arrow keys or ctrl +a or d, up shipt+w or s
        transform.Translate(xInput, yInput, 0);

        // use Mouse click Or left ctrl on kye board  to Fire1
        
        if (Input.GetButtonDown( "Fire1"))
        {
            print("left click on mouse or left ctrl key was pressed");
        }
    } 
}
