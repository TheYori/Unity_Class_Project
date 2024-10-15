using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class DateScript : MonoBehaviour
{
    public TextMeshProUGUI dateText;  // Reference to the UI Text component

    void Update()
    {
        // Get the current time
        DateTime currentDate = DateTime.Now;

        // Format the time (HH:mm)
        string timeString = currentDate.ToString("dd/MM/yyyy");

        // Update the Text component with the current time
        dateText.text = timeString;
    }
}
