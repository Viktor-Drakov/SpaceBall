using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BigBallScript : MonoBehaviour
{
    public float minSpeed = -2f;
    public float maxSpeed = 2f;
    public int ballPoints;
    public Rigidbody2D rb;
    public LogicScript logic;
    public GameObject mediumBall;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = new Vector2(Random.Range(minSpeed, maxSpeed), Random.Range(minSpeed, maxSpeed));
        logic = GameObject.FindWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        logic.AddScore(ballPoints);
        Destroy();
    }

    public virtual void Destroy()
    {
        Instantiate(mediumBall, transform.position, transform.rotation);
        Instantiate(mediumBall, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
