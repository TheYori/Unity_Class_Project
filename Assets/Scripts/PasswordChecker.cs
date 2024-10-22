using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PasswordChecker : MonoBehaviour
{
    public TMP_InputField inputField;  // The InputField in the UI
    public string targetWord = "corvus corax";  // The word we want to check against
    public TextMeshProUGUI feedbackText; // Optional: A text UI element to provide feedback

    public GameObject specificObject; //Object you want to open.
    public GameObject objectToDisable; //Object you want to close.

    void Start()
    {
        // Add a listener to detect when the "Enter" key is pressed (when input is submitted)
        inputField.onSubmit.AddListener(delegate { CheckInput(); });
    }

    // Method to check the input
    public void CheckInput()
    {
        string userInput = inputField.text;  // Get the text from the TMP InputField

        // Compare the input to the target word (ignoring case)
        if (userInput.Equals(targetWord, System.StringComparison.OrdinalIgnoreCase))
        {
            Debug.Log("Correct word entered! Triggering action...");
            TriggerAction();  // Call another method to trigger the desired action
        }
        else
        {
            Debug.Log("Incorrect word.");

            if (feedbackText != null)
            {
                feedbackText.text = "Incorrect word, try again!";
            }
        }
    }

    // Method to trigger the desired action (e.g., activating an object, playing a sound, etc.)
    void TriggerAction()
    {
        // Toggle the active state of the object
        bool isActive = specificObject.activeSelf;
        specificObject.SetActive(!isActive);
        objectToDisable.SetActive(false);
    }
}
