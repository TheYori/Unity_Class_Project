using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotificationMenu : MonoBehaviour
{
    public float speed = 5f;           // Speed of movement
    public float targetXPosition = -10f; // Target X position to stop movement

    private Vector3 originalPosition;      // Store the original position of the object
    private bool isMovingToLeft = true;    // Toggle for direction
    private bool isMoving = false; // Tracks whether the object is moving

    void Start()
    {
        // Save the original position when the game starts
        originalPosition = transform.position;
    }

    public void MoveToFrame()
    {
        isMoving = true; // Start the movement when the button is pressed
    }

    void Update()
    {
        if (isMoving)
        {
            if (isMovingToLeft)
            {
                // Move the object to the left until it reaches the target position
                if (transform.position.x > targetXPosition)
                {
                    transform.position += Vector3.left * speed * Time.deltaTime;
                }
                else
                {
                    // Stop moving and toggle direction when the target position is reached
                    isMoving = false;
                    isMovingToLeft = false;
                }
            }
            else
            {
                // Move the object back to the original position
                if (transform.position.x < originalPosition.x)
                {
                    transform.position += Vector3.right * speed * Time.deltaTime;
                }
                else
                {
                    // Stop moving and toggle direction when the original position is reached
                    isMoving = false;
                    isMovingToLeft = true;
                }
            }
        }
    }
}
