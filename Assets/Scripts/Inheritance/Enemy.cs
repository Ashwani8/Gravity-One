using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{ // note the Monobehaviour is inherited by Enymy and by any class using Enemy;
 // if we make any funtion private we won't be able to access the function.
    public void Attack()
    {
        Debug.Log("Enemy Attack");
    }
}
