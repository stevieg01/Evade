using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spike2 : MonoBehaviour
{
    //variables for speed
    public float ySpeed = 0; //variable for vertical speed

    //variables for borders

    private float yBorder = 4.5f; //variable for vertical border

    //variables for move state

    public bool yMove = true;

    // Start is called before the first frame update
    void Start()
    {
        ySpeed = 0.1525f;   //declare value for vertical speed
    }

    // Update is called once per frame
    void Update()
    {

        //vertical movement
        if (yMove == true)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + ySpeed); //move up
        }

        else
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - ySpeed);   //move down
        }
        if (transform.position.y >= yBorder)
        {
            yMove = false;
        }

        if (transform.position.y <= -yBorder)
        {
            yMove = true;
        }
    }
}