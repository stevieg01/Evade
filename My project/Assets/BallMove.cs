using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallMove : MonoBehaviour
{
    //variables
    private Vector2 direction;      //control direction of movement
    public bool goingUp;
    public bool goingDown;
    public bool goingLeft;
    public bool goingRight;

    List<Transform> segments;       //variable to store all the parts of the body of the snake 
    public Transform bodyPrefab;    //variable to store the body

    // Start is called before the first frame update
    void Start()
    {
        segments = new List<Transform>();       //create a new list
        segments.Add(transform);                //add the head of the snake to the list
    }

    // Update is called once per frame
    void Update()
    {
        //change direction of the snake
        if (Input.GetKeyDown(KeyCode.W) && goingDown != true)        //when W key is pressed
        {
            direction = Vector2.up;             //go up
            goingUp = true;
            goingDown = false;
            goingLeft = false;
            goingRight = false;
        }
        else if (Input.GetKeyDown(KeyCode.A) && goingRight != true)   //when A key is pressed
        {
            direction = Vector2.left;           //go left
            goingUp = false;
            goingDown = false;
            goingLeft = true;
            goingRight = false;
        }
        else if (Input.GetKeyDown(KeyCode.S) && goingUp != true)   //when S key is pressed
        {
            direction = Vector2.down;           //go down
            goingUp = false;
            goingDown = true;
            goingLeft = false;
            goingRight = false;
        }
        else if (Input.GetKeyDown(KeyCode.D) && goingLeft != true)   //when D key is pressed
        {
            direction = Vector2.right;           //go right
            goingUp = false;
            goingDown = false;
            goingLeft = false;
            goingRight = true;
        }
    }

    //FixedUpdate is called at a fix interval
    void FixedUpdate()
    {
        //move te body of the snake
        for (int i = segments.Count - 1; i > 0; i--)                //for each segment of the snake
        {
            segments[i].position = segments[i - 1].position;        //move the body
        }

        //move the snake
        this.transform.position = new Vector2(                      //get the position
            Mathf.Round(this.transform.position.x) + direction.x,   //round the number add value to X
            Mathf.Round(this.transform.position.y) + direction.y    //round the number add value to Y
            );
    }


        else if (other.tag == "Obstacle")   //check if the other object is an obstacle
        {
            //Debug.Log("Hit")
            SceneManager.LoadScene("EndScene"); //chage to the end scene
            SceneManager.LoadScene("GameScene"); //restart the game
        }   
}