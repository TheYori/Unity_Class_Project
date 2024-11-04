// AUTHOUR: Ricki G. Matwijkiw
// Assited by ChatGPT-4 Turbo model
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PasswordChecker : MonoBehaviour
{
    public TMP_InputField inputField;  
    public string codeWord = "corvus corax";  // The codeword we chose
    public TextMeshProUGUI feedbackText; // A textbox that tells if the code is wrong

    public GameObject specificObject; //Object we want to open.
    public GameObject objectToDisable; //Object we want to close.

    void Start()
    {
        // A listener that detects the "Enter" key when pressed
        inputField.onSubmit.AddListener(delegate { CheckInput(); });
    }

    // Method to check the input
    public void CheckInput()
    {
        string userInput = inputField.text;

        // Compares input to the target word (ignoring case)
        if (userInput.Equals(codeWord, System.StringComparison.OrdinalIgnoreCase))
        {
            Debug.Log("CORRECT");
            TriggerAction();
        }
        else
        {
            Debug.Log("WRONG");

            if (feedbackText != null)
            {
                feedbackText.text = "Failure...";
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
