using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : MonoBehaviour
{
    private void Start()
    {
        Dragon dragon = new Dragon();
        dragon.Attack(); 
    }
    public void Attack()
    {
        print("Dragon Attack");
    }
} // Dragon class ends here
