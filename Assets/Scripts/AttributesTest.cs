using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttributesTest : MonoBehaviour
{// public variable can be changed from other script, but we cant to access in only in the main script but not by other 
    // we will use [serializeField] and make the variable private, it will be accessible in first script from unity
 
    [SerializeField]
    private int speedx; // will be visible in inspector


    // will not be visible in inspector
    [HideInInspector]     public int speedy = 1;

    // creating a sliding bar in th UI using Range
    [Range(0, 20)]
    public float speedZ;

    // we can also hide public variable from the UI
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speedx * Time.deltaTime, 0, 0);
        transform.Translate(0, speedy * Time.deltaTime, 0);
    }
}
