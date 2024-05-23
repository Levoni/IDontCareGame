using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float xSpeed = 150.0f;
    public float xBaseSpeed = 150.0f;
    public float sprintIncrement;
    public float ySpeed = 200.0f;
    public Rigidbody2D rigidbody2D;
    public Vector2 movement;
    public float jumpForce = 1000;
    public bool sprinting = false;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
        sprintIncrement = xSpeed / 2;
    }

    // Update is called once per frame
    void Update()
    {
        //Transform tempTransform = gameObject.GetComponent<Transform>();
        //Vector3 tempPosition = new Vector3(tempTransform.position.x, tempTransform.position.y, tempTransform.position.z);

        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    tempPosition.x = tempPosition.x - speed;
        //    tempTransform.position = tempPosition;
        //}
        //if (Input.GetKeyDown(KeyCode.D))
        //{
        //    tempPosition.x = tempPosition.x + speed;
        //    tempTransform.position = tempPosition;
        //}

        // stops movement up when button is released; changed movement pattern
        //if (Input.GetKeyUp(KeyCode.W))
        //{
        //    y = true;
        //    movement.y = 0;
        //}
        
        // constant movement up using Rigidbody 
        //if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        //{
        //    y = false;
        //    movement.y = Input.GetAxis("Vertical") * ySpeed * Time.deltaTime;
        //}

        movement = new Vector2(0, rigidbody2D.velocity.y);

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            xSpeed += sprintIncrement;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            xSpeed = xBaseSpeed;
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
           movement.x = Input.GetAxis("Horizontal") * xSpeed * Time.deltaTime;
        }

        rigidbody2D.velocity = movement;    // ORDER MATTERS!!

        if (Input.GetKeyDown(KeyCode.W))
        {
            rigidbody2D.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }


        // double jump
        // raycast downward

    }


}
