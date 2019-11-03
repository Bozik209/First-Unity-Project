using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Reference to the Rigidbody comopnent called "rb"
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewatsForce = 500f;

    // Update is called once per frame
    // Use FixedUpdate() because we mess whit physics
    void FixedUpdate()
    {
        //Add a forward force  
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);  // Time.deltaTime = The completion time in seconds since the last frame

        if(Input.GetKey("d") || Input.GetKey("right"))
        { 
            // Force the the right
            rb.AddForce(sidewatsForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            // Force the the left
            rb.AddForce(-sidewatsForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

       
        if (rb.name == "Player cube" && rb.position.y < -1f) 
        {
            FindObjectOfType<GameManager>().EndGame();
            Debug.Log("y "+rb.position.y);
                }
    }
}
