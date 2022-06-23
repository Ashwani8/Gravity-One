using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarTest : MonoBehaviour
{
    public Car myCar; // after [System.Serializable] we will access this unity inspector 
    // Start is called before the first frame update
    void Start()
    {
        // create a new instant of Car class
        //Car myCar = new Car();

        //// we give attributes to myCar
        //myCar.speed = 12.5f;
        //myCar.topSpeed = 20;
        //myCar.color = "Red";

        //// create another isntant of the car
        //Car suzuki = new Car(12f);
        //suzuki.speed = 10f;
        //suzuki.topSpeed = 15;
        //suzuki.color = "White";

        //myCar.CarSpeed();
        //suzuki.CarSpeed();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
