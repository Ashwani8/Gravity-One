using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : MonoBehaviour
{
    private void Start()
    {
        Dragon dragon = new Dragon();
        dragon.Attack();

        // create new instant of blue dragon
        Dragon dragonB = new BlueDragon(); // we can do this since BlueDragon inderits from Dragon
                dragonB.Attack(); // this will call blue dragon

        Dragon dragonR = new RedDragon();
        dragonR.Attack();
    }
    public virtual void Attack()
    {
        print("Dragon Attack");
    }
} // Dragon class ends here

// we plan to creat multiple classes here which also inherited Dragon class and thus monobehaviour.

public class BlueDragon: Dragon
    {
    public override void Attack()
    { // since we are using the same name of the function, Attack, it will hide the function from base class Dragon.
       
        print(" Blue Dragon Attack");
    }
    
    } // Blue Dragon ends class ends here

public class RedDragon: Dragon
{
    public override void Attack()
    {
        print("Red Dragon attack");
    }
}