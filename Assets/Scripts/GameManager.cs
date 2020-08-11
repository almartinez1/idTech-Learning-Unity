using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int coins = 20;

    // Start is called before the first frame update
    void Start()
    {
        int coinGenerated = 1;

        /*
        while (coinGenerated <= coins)
        {
            Debug.Log(coinGenerated + " coins generated");
            coinGenerated++; // coinGenerated = coinGenerated + 1;
        }
        */

        for (int i = 1; i <= coins; i++)
        {
            Debug.Log(i + " coins generated");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
