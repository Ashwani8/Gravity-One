using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsTest : MonoBehaviour
{
    Rigidbody rb;// get access to rigid body
    float xInput, zInput;
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
       // rb.velocity = new Vector3(0, 0, speed);
    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxis("Horizontal"); // move smoothly and give us x value when we press left arrow key
        zInput = Input.GetAxis("Vertical"); // move smoothly FWD and give us y value when we press right arrow key
        print(xInput + zInput);
    
    
    }

    // A must for Physics property/function, get called in more reliable way
    void FixedUpdate()
    {
        rb.velocity = new Vector3(xInput*speed,rb.velocity.y , zInput*speed); // note the velocity in y axis
        // is controlled by gravity, so we are just reading whatever it is rb.velocity.y
    }
}
