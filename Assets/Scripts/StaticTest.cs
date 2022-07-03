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
      //  Bullets.noOfBullets = 10;
        
        // second instant of the Bullet class 
        Bullets bullets2 = new Bullets();
        // bullets2.noOfBullets = 20;

      //  Bullets.noOfBullets = 20;

        Bullets bullets3 = new Bullets(); 
        Debug.Log("number of bullets: " + Bullets.noOfBullets);
        Bullets.ShowBullets();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
} // StaticTest class ends here

// use of Static variable
public class Bullets
{// A static variable is attached to a class and all instances will have same value
    public static int noOfBullets =0 ; 
    // how many instances of a class we have created?
    public Bullets()
    {
        noOfBullets++; // each time an instant is created the counter will increase by one
    }
    public static void ShowBullets()
    {
        Debug.Log("Number if Bullets : " + noOfBullets);
    }
}