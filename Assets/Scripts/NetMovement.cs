using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetMovement : MonoBehaviour
{
    //Rigidbody component of Net
    private Rigidbody2D rigidBodyComponent;

    //Variable to store our movement for the net
    private Vector2 movement;

    //Speed of our net
    public Vector2 speed = new Vector2(5, 0);

    // Update is called once per frame
    void Update()
    {
        movement = GetMovement();
    }

    // FixedUpdate that is more suited to physics updates
    void FixedUpdate()
    {
        //Get a reference to the rigidbody component of the net
        if (rigidBodyComponent == null)
        {
            rigidBodyComponent = GetComponent<Rigidbody2D>();
        }

        //Update the net's velocity to the movement
        rigidBodyComponent.velocity = movement;
    }

    //Function to return the input from the player.
    private Vector2 GetMovement()
    {
        //Get the input from the player
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        //Return the movement using the product of the input and the speed vectors
        return new Vector2(speed.x * inputX, speed.y * inputY);
    }
}
