using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttributesTest : MonoBehaviour
{// public variable can be changed from other script, but we cant to access in only in the main script but not by other 
    // we will use [serializeField] and make the variable private, it will be accessible in first script from unity
 
    [SerializeField]
    private int speed; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
