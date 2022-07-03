using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MonmouthXr;

public class NameSpaceTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      
        Utilities.PrintMcXr(); // note that we are using Utilities class from MonmouthXr name space

        // we can call a function from another namespace without "using MonmouthXr" but then
        // we have to write it like shown below.
       // MonmouthXr.Utilities.PrintMcXr();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
