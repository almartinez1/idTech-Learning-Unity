using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Datatype VariableName = Value;
    public int wheels = 4;
    string playerName = "Carbot";
    int speed = 70;
    bool powerUp = false;

    // Start is called before the first frame update
    void Start()
    {
        /*
        Debug.Log("I am Carbot - bringer of justice");
        Debug.Log(playerName + " has " + wheels + " wheels.");

        wheels = wheels + 2;
        Debug.Log(playerName + " got an upgrade, they now have " + wheels + " wheels.");

        wheels = 10;
        Debug.Log(playerName + " got a SUPER upgrade, they now have " + wheels + "wheels.");
        */

        if (wheels < 4)
        {
            Debug.Log("Not enough wheels, the burglar gets away.");
            speed = 0;
        }
        else if (wheels>=4 && wheels <= 6)
        {
            Debug.Log("You're in pursuit.");
            speed = speed + 30;
        }
        else if (wheels > 6 && wheels < 10)
        {
            Debug.Log("Power Up.");
            powerUp = true;
        }
        else
        {
            Debug.Log("SUPER POWER UP.");
            speed = speed + 100;
            powerUp = true;
        }

        if (speed > 100 || powerUp == true)
        {
            Debug.Log("You Caught the burglar.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
