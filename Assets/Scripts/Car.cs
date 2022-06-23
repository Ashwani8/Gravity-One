using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
// note the System.Serializable inside the square baracket.
// this will allow access add values to public variable from other script 

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
   // default constructor, no void, no returns
    public Car()
    {
        Debug.Log("Car() was called");
    }
    // One can create multiple construct
    public Car(float spd)
    {// construct with one input of type float
        this.speed = spd; // repalce speed, with the enetred value of the function
        Debug.Log("Car(float) was called");
    }
    public Car(float speed, string color)
    { // construct with two inputs, and can be used only for two inputs
        this.speed = speed;
        this.color = color;
        Debug.Log("Car(float, speed) was called");
    }
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
