using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTEst : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // will destroy colliding object with tag Enemy
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="Enemy")
        {
            Destroy(collision.gameObject); //whatever we collide with, will be destroyed
        }
    }
}
