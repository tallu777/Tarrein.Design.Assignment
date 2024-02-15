using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Move_Script : MonoBehaviour
{
    public Rigidbody ball;
    public float ball_force;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Code for Move Forward
        if (Input.GetKey(KeyCode.UpArrow))
        {
            ball.AddForce(0f, 0f, ball_force);
        }
        //Code for Move Backward
        if (Input.GetKey(KeyCode.DownArrow))
        {
            ball.AddForce(0f, 0f, -ball_force);
        }
        //Code for Move left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            ball.AddForce(-ball_force, 0f, 0f);
        }
        //Code for Move Right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            ball.AddForce(ball_force, 0f, 0f);
        }
    }
}
