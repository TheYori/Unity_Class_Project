using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class DigitalClock : MonoBehaviour
{
    public TextMeshProUGUI clockText;  // Reference to the UI Text component

    void Update()
    {
        // Get the current time
        DateTime currentTime = DateTime.Now;

        // Format the time (HH:mm)
        string timeString = currentTime.ToString("HH:mm");

        // Update the Text component with the current time
        clockText.text = timeString;
    }
}
