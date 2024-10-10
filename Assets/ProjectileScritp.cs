using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class ProjectileScritp : MonoBehaviour
{
    public float proSpeed;
    public Rigidbody2D rb;
    public Transform shipTr;
    private float screenTop = 6.1f;
    private float screenBottom = -6.1f;
    private float screenLeft = -10.8f;
    private float screenRight = 10.8f;
    // Start is called before the first frame update
    void Start()
    {
        shipTr = GameObject.FindWithTag("Ship").GetComponent<Transform>();
        rb.velocity = shipTr.up * proSpeed;
        transform.rotation = shipTr.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        // If passed the limits of the camera
        if (transform.position.x > screenRight || transform.position.x < screenLeft || transform.position.y > screenTop || transform.position.y < screenBottom)
        {
            // This game object is destoyed
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
