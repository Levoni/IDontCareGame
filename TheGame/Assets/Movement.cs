using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 50.0f;
    public Rigidbody2D rigidbody2D;
    public Vector2 movement;
    public Vector2 temp;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
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

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            movement = new Vector2(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0);
            movement.y = rigidbody2D.velocity.y + (Input.GetAxis("Vertical") * speed * Time.deltaTime); // fix; constant increase of speed upwards
        }
        else
        {
            movement = new Vector2(0, rigidbody2D.velocity.y);
        }
        rigidbody2D.velocity = movement;

        // stop horizontal movement and go up until let go then down

        // double jump
        // raycast downward

    }


}
