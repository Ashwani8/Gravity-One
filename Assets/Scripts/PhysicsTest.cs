using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsTest : MonoBehaviour
{
    Rigidbody rb;// get access to rigid body
    float xInput, yInput;
    public float speed;
    // it is good idea to use awake method rathar than start for position. similarly
    // it is good idea to use FixedUpdate for Physics activities rather than regular update
    // method as the later depends on computer speed
    // Start is called before the first frame update
    private void Awake()
    {
        rb = GetComponent<Rigidbody>(); // get access when app awake
    }
    void Start()
    {
        // move game object with rigid body in forward (z-) direction with the given velocity
        rb.velocity = new Vector3(0, 0, speed);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
