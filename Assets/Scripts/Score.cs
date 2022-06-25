using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// we would like to demonstarate some properties of the class
public class Score 
{
    private int point;
    public int Point
    { 
        get
        {
            return point;
        }

        set
        {
            point = value;
        }
    }
}
