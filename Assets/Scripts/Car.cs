using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// This is just a simple class without any monobheaviour
// we Can Not attach it directly to game object
public class Car 
{
    // car is an object with attributes and behavior
    // attributes like color, number of door, top speed
    // behaviour like, moving forward or backward , break in other words functions or action

    public string color;
    public int topSpeed;
    public float speed;


    void Move()
    {
        Debug.Log("Moving");
    }

    void ApplyBreaks()
    {
        Debug.Log("Applying breaks");
    }
    
    public void CarSpeed()
    {
        Debug.Log(speed);
    }
}
