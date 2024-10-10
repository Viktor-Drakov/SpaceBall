using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawnerScript : MonoBehaviour
{
    public float spawnRate = 5f;
    private float timer = 0;
    public GameObject bigBall;
    private float screenTop = 6.1f;
    private float screenBottom = -6.1f;
    private float screenLeft = -10.8f;
    private float screenRight = 10.8f;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(bigBall, new Vector2(Random.Range(screenLeft, screenRight), Random.Range(screenBottom, screenTop)), transform.rotation);
        Instantiate(bigBall, new Vector2(Random.Range(screenLeft, screenRight), Random.Range(screenBottom, screenTop)), transform.rotation);
        Instantiate(bigBall, new Vector2(Random.Range(screenLeft, screenRight), Random.Range(screenBottom, screenTop)), transform.rotation);
        Instantiate(bigBall, new Vector2(Random.Range(screenLeft, screenRight), Random.Range(screenBottom, screenTop)), transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        } else
        {
            timer = 0;
            SpawnBall();
        }
    }

    void SpawnBall()
    {
        Instantiate(bigBall, new Vector2(Random.Range(screenLeft, screenRight), Random.Range(screenBottom, screenTop)), transform.rotation);
    }
}
