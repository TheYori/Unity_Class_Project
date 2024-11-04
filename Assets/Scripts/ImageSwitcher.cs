// AUTHOUR: Ricki G. Matwijkiw
// Assited by ChatGPT-4 Turbo model
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageSwitcher : MonoBehaviour
{
    public Image imageObject;      // The Image component you want to change
    public Sprite sprite1;         // First sprite
    public Sprite sprite2;         // Second sprite
    public GameObject checkObject; // The object to check if it's enabled

    public float interval = 3f;    // Time in seconds before switching back

    private bool isSwitching = false;

    void Update()
    {
        // Check if the specific object is enabled and start the coroutine
        if (checkObject.activeInHierarchy && !isSwitching)
        {
            StartCoroutine(ClueChangeLoop());
        }
    }

    IEnumerator ClueChangeLoop()
    {
        isSwitching = true;

        while (checkObject.activeInHierarchy)
        {
            // Change to sprite2 after interval
            yield return new WaitForSeconds(interval);
            imageObject.sprite = sprite2;

            // Wait for 1 second then switch back to sprite1
            yield return new WaitForSeconds(1f);
            imageObject.sprite = sprite1;
        }

        isSwitching = false; // Reset if the checkObject is disabled
    }
}
