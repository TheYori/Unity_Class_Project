using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PasswordChecker : MonoBehaviour
{
    public TMP_InputField inputField;  
    public string targetWord = "corvus corax";  // The codeword we chose
    public TextMeshProUGUI feedbackText; // A textbox that tells if the code is wrong

    public GameObject specificObject; //Object we want to open.
    public GameObject objectToDisable; //Object we want to close.

    void Start()
    {
        // A listener to detect the "Enter" key
        inputField.onSubmit.AddListener(delegate { CheckInput(); });
    }

    // Method to check the input
    public void CheckInput()
    {
        string userInput = inputField.text;

        // Compare the input to the target word (ignoring case)
        if (userInput.Equals(targetWord, System.StringComparison.OrdinalIgnoreCase))
        {
            Debug.Log("Correct word entered! Triggering action...");
            TriggerAction();
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

    // Method triggers an object with the puzzle reward
    void TriggerAction()
    {
        // Toggle the active state of the reward object
        bool isActive = specificObject.activeSelf;
        specificObject.SetActive(!isActive);
        objectToDisable.SetActive(false);
    }
}
