using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenWrappingScript : MonoBehaviour
{
    private float screenTop = 6.1f;
    private float screenBottom = -6.1f;
    private float screenLeft = -10.8f;
    private float screenRight = 10.8f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Shorthand for update the position
        Vector3 newPosition = transform.position;

        // Check if the player has moved beyond the limits of the camera
        if (transform.position.y > screenTop)
        {
            // Update the player position in the opposite position
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

        // Shorthand for update position
        transform.position = newPosition;
    }
}
