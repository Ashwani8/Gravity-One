using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// we will create and use a Coroutine. This is used to halt program for something else
public class CoRoutineTest : MonoBehaviour
{
    //GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Test"); // calling Coroutine
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    IEnumerator Test()
    {
        print("Coroutine start");
        yield return new WaitForSeconds(2f);
        this.GetComponent<Renderer>().material.color = Color.red;
        yield return new WaitForSeconds(2f);
        this.GetComponent<Renderer>().material.color = Color.blue;
        print("Coroutine ends");
    }
}
