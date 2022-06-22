using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// The scrpit should be attached to the the looker, not to the target
public class LookAtTest : MonoBehaviour
{
    // game object at which we will be looking
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // [1] we will look at the target if moved in any direction
        // transform.LookAt(target.transform);

        // [2[ method, when we want not to look at when target is moved in that direction say y axis

        Vector3 targetPosition = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z);

        transform.LookAt(targetPosition);
    }
}
