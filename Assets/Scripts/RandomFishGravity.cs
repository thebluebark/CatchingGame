using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomFishGravity : MonoBehaviour
{
    //Set the speed range
    public float minSpeed = 0.50f;
    public float maxSpeed = 1.20f;

    //Variable to hold rigidbody2D component of fish
    private Rigidbody2D fishrigidbody;

    // Start is called before the first frame update
    void Start()
    {
        //Grab the rigidbody2d after spawning
        fishrigidbody = GetComponent<Rigidbody2D>();

        //Set the gravity scale of the fish
        fishrigidbody.gravityScale = Random.Range(minSpeed, maxSpeed);
    }
}
