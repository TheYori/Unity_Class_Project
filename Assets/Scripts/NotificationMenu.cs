using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotificationMenu : MonoBehaviour
{
    public float speed = 5f;                   // Speed of movement
    public RectTransform leftStopper;          // target UI element
    public RectTransform rightStopper;         // target UI element

    private RectTransform rectTransform;       // Reference to this UI element's RectTransform
    private bool isMoving = false;             // Track whether the object is moving
    private bool isVisible = false;

    void Start()
    {
        // Get the RectTransform component of the UI element
        rectTransform = GetComponent<RectTransform>();
    }

    // Method to start movement when the button is clicked
    public void StartMovement()
    {
        isMoving = true;
    }

    void Update()
    {
        if (isMoving && isVisible == false)
        {
            // Move the UI element to the left
            rectTransform.anchoredPosition += Vector2.left * speed * Time.deltaTime;

            // Check for collision by comparing positions
            if (RectTransformOverlap(rectTransform, leftStopper))
            {
                isMoving = false; // Stop movement if overlap with target is detected
                isVisible = true;
            }
        }

        if (isMoving && isVisible)
        {
            // Move the UI element to the left
            rectTransform.anchoredPosition += Vector2.right * speed * Time.deltaTime;

            // Check for collision by comparing positions
            if (RectTransformOverlap(rectTransform, rightStopper))
            {
                isMoving = false; // Stop movement if overlap with target is detected
                isVisible = false;
            }
        }
    }

    // Method to check if two RectTransforms overlap
    private bool RectTransformOverlap(RectTransform rect1, RectTransform rect2)
    {
        return RectTransformUtility.RectangleContainsScreenPoint(rect1, rect2.position) ||
               RectTransformUtility.RectangleContainsScreenPoint(rect2, rect1.position);
    }
}
