using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Datatype VariableName = Value;
    int wheels = 4;
    string playerName = "Carbot";
    int speed = 70;
    bool powerUp = false;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("I am Carbot - bringer of justice");
        Debug.Log(playerName + " has " + wheels + " wheels.");

        wheels = wheels + 2;
        Debug.Log(playerName + " got an upgrade, they now have " + wheels + " wheels.");

        wheels = 10;
        Debug.Log(playerName + " got a SUPER upgrade, they now have " + wheels + "wheels.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
