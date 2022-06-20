using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// search and find in the herarchy 
// the script is attached to an empty GameObject which precedes Cube, sphere etc.
// although these objects are not childeren of the empty Game object, it works.
public class FindingObjects : MonoBehaviour
{
    GameObject searchObj;
    // Start is called before the first frame update
    void Start()
    {
       searchObj= GameObject.Find("Cube");
        Destroy(searchObj);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
