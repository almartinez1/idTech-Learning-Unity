using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{

    public int speed = 5;
    bool movingRight = false;

    float posx;

    // Start is called before the first frame update
    void Start()
    {
        // Get start x position of gameobject
        posx = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >=posx + 2.0f)
        {
            movingRight = false;
        }
        if (transform.position.x <= posx - 2.0f)
        {
            movingRight = true;
        }

        if (movingRight == true)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }
}
