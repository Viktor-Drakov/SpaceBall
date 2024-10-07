using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenWrappingScript : MonoBehaviour
{
    private float screenTop;
    private float screenBottom;
    private float screenLeft;
    private float screenRight;
    // Start is called before the first frame update
    void Start()
    {
        // Calculate camera boundaries in world units
        Camera cam = Camera.main;
        screenTop = cam.orthographicSize;
        screenBottom = -cam.orthographicSize;
        screenRight = cam.aspect * screenTop;
        screenLeft = -screenRight;
    }

    // Update is called once per frame
    void Update()
    {
        UnityEngine.Vector2 newPosition = transform.position;  // Specify UnityEngine.Vector2 explicitly

        // Check if the player has moved beyond the screen boundaries
        if (transform.position.y > screenTop)
        {
            newPosition.y = screenBottom;
        }
        else if (transform.position.y < screenBottom)
        {
            newPosition.y = screenTop;
        }

        if (transform.position.x > screenRight)
        {
            newPosition.x = screenLeft;
        }
        else if (transform.position.x < screenLeft)
        {
            newPosition.x = screenRight;
        }

        // Apply the new position if the player has gone off the screen
        transform.position = newPosition;
    }
}
