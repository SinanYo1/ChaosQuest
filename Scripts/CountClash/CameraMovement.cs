using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float cameraSpeed = 1.0f;
    
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        // Bewegt die Kamera
        if (Input.GetKey("a"))
        {
            Vector3 movementVector = new Vector3(-1, 0, 0);
            transform.Translate((cameraSpeed * movementVector) * Time.deltaTime);
        }

        if (Input.GetKey("d"))
        {
            Vector3 movementVector = new Vector3(1, 0, 0);
            transform.Translate((cameraSpeed * movementVector) * Time.deltaTime);
        }
        // Grenzt die Position der Kamera ein das sie nicht aus der Map fliegt
        Vector3 currentPosition = transform.position;
        currentPosition.x = Mathf.Clamp(currentPosition.x, -115, 81); // min und max X-Werte
        transform.position = currentPosition;
    }
}

// Dieser Code ist zuständig für die Kamera Bewegung vom Ersten Spieler.
