using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayTest : MonoBehaviour
{
    // create an array to hold 4 GameObject, so we need to create an array of type GameObject
    public GameObject[] gameObjects = new GameObject[4];

    // Arry of type Color for game objects
    public Color[] colors;
    // Start is called before the first frame update
    void Start()
    {
        // Destroy(gameObjects[2],2f);
        // color each game object with array index with the correspondeing array color index.
        // we acces game objects with thier corresponding index
        // > Getcomponent rendering properties > materils > assign corresponding color

        gameObjects[0].GetComponent<Renderer>().material.color = colors[0];
        // use ctrl +D to duplicate a line code
        gameObjects[1].GetComponent<Renderer>().material.color = colors[1];
        gameObjects[2].GetComponent<Renderer>().material.color = colors[2];
        gameObjects[3].GetComponent<Renderer>().material.color = colors[3];
        // if we don't know the length of the array we case use array.Length command
        print(colors.Length);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
