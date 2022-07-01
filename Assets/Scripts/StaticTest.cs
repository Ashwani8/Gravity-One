using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// I am defining two classes here
public class StaticTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // first instant of the Bullet class 
        Bullets bullets1 = new Bullets();
        // bullets1.noOfBullets = 10;
        //print("number of bullets: " + bullets1.noOfBullets);
        // with statics variable, we have to use class for every instant, and the value
        // assigned will be same for all instances.
        Bullets.noOfBullets = 10;
        
        // second instant of the Bullet class 
        Bullets bullets2 = new Bullets();
        // bullets2.noOfBullets = 20;
        Bullets.noOfBullets = 20;
      Debug.Log("number of bullets: " + Bullets.noOfBullets);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
} // StaticTest class ends here

// use of Static variable
public class Bullets
{
    public static int noOfBullets; 
    // A static variable is attached to a class and all instances will have same value
}