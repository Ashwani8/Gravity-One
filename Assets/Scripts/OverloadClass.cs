using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverloadClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Fun fun = new Fun();
        fun.PrintFloat(2.5f);
        fun.PrintInt(3);
        fun.PrintString("Monmouth");
       // note that we are calling the funtion with the same name, but input type is different
       // the program will call appropriate funtion
        fun.Print(2);
        fun.Print(2.9f);
        fun.Print("Ashwani");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
} // monbehavious ends here

public class Fun
{
    public void PrintInt(int i)
    {
        Debug.Log(i);
    }

    public void PrintFloat(float i)
    {
        Debug.Log(i);
    }

    public void PrintString(string i)
    {
        Debug.Log(i);
    }

    // we cannot create a function with same name and same parameter.
    // however we can create funtion with the same name but differnt type of input
    // this is called overloading
    public void Print(int i)
    {
        Debug.Log(" Print integer function was called " + i);
    }
    public void Print(float i)
    {
        Debug.Log(" Print float function was called " + i);
    }

    public void Print(string i)
    {
        Debug.Log(" Print String function was called " + i);
    }
}
