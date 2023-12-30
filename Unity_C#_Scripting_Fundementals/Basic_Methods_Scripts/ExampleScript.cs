using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript : MonoBehaviour
{

    /*
    Assignment Operators: 
    =
    += (speed = speed + y ==> speed += y)
    -=
    *=
    /=
    %= 
    */ 
    public float speed = 0f;
    public float distance = 0.0f;
    public float time = 0.0f;

    public float maxSpeedLimit = 70.0f;
    public float minSpeedLimit = 40.0f; 
   
    void Start()
    {
       
        
    }

  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpeedCheck();
        }


    }

    void SpeedCheck()
    {
        speed = distance / time;

        if (speed > maxSpeedLimit)
        {
            print("You are speeding");
        }
        else if (speed < minSpeedLimit)
        {
            print("Going too slow"); 
        }
        else if (speed == maxSpeedLimit || speed == minSpeedLimit)
        {
            print("You are very close to breaking the law");
        }
        else
        {
            print("You're going the speed limit");
        }

    }
}
