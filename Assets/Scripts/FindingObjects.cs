using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// search and find in the herarchy 
// the script is attached to an empty GameObject which precedes Cube, sphere etc.
// although these objects are not childeren of the empty Game object, it works.
public class FindingObjects : MonoBehaviour
{
    GameObject searchObj, searchObj2, findWithTagObj;

    // create gameobject array to store multiple game objects with same tag
    GameObject[] enemies;

    // Start is called before the first frame update
    void Start()
    {
        //  searchObj= GameObject.Find("Capsule");
        //  Destroy(searchObj);
        // searching a child object in heriarchy
        //  searchObj2 = GameObject.Find("Cube/Cube2/Enemy");
        //  Destroy(searchObj2, 2f);
        // searching with tag
        //  findWithTagObj = GameObject.FindGameObjectWithTag("Ball");
        //  Destroy(findWithTagObj, 3f);

        // Find multiple Game objects with same Tag, store them in an array, and then pick up
        // one by one to destroy them,

        enemies = GameObject.FindGameObjectsWithTag("Enemy");

        // we create a new game object enemy to sort out enemies array and destroy objects in foreach loop
        foreach(GameObject enemy in enemies)
        {
            Destroy(enemy);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
