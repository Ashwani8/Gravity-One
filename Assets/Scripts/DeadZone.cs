using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//When other game object enter the trigger zone its color will change to yellow.
// make sure to check Trigger on the collision box.
public class DeadZone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
    }
    void OnTriggerExit(Collider other)
    {
        other.gameObject.GetComponent<Renderer>().material.color = Color.green;
    }
}

