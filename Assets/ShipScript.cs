using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class ShipScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float rotationSpeed = 200f;
    public float thrustForce = 0.5f;
    public GameObject projectile;
    public Transform shootPoint;
    public GameObject gameOverScreen;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Variable to get the values -1 for the left arrow and 1 for the right arrow
        float rotationInput = Input.GetAxis("Horizontal");
        // Rotation in rotationSpeed value in real tieme
        transform.Rotate(Vector3.forward * -rotationInput * rotationSpeed * Time.deltaTime);
        // If the up arrow or "W" is pressed
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            // Go in the direction of the sprite is facing in the force of thrustForce value
            rb.AddForce(transform.up * thrustForce);
        }
        // If the space key down
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Instatiate a projectile in the shootPoint transform position
            Instantiate(projectile, shootPoint.position, shootPoint.rotation);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ShipDestroyed();
    }

    void ShipDestroyed()
    {
        Debug.Log("Ship destroyed");
        gameOverScreen.SetActive(enabled);
        Destroy(gameObject);
    }
}
