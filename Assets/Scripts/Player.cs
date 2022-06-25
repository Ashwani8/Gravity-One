using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Score score = new Score(); // creating instance of class Score
        score.Point = 5;
        print(score.Point); // note we cannot print score directly
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
