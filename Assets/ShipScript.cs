using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class ShipScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float rotationSpeed = 10f;
    public float thrustForce = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the ship based on the left and right direction
        float rotationInput = Input.GetAxis("Horizontal");
        transform.Rotate(0, 0, -rotationInput * rotationSpeed * Time.deltaTime);

        // If the up arrow is
        if (Input.GetKey(KeyCode.UpArrow))
        {
            // Go in the direction of the sprite is facing
            rb.AddForce(transform.up * thrustForce);
        }
    }
}
