using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class ClockAndDate : MonoBehaviour
{
    public TextMeshProUGUI clockText; 
    public TextMeshProUGUI dateText; 

    void Update()
    {
        // Get the current time
        DateTime currentTime = DateTime.Now;

        // Format the time (HH:mm)
        string timeString = currentTime.ToString("HH:mm");

        // Update the Text component with the current time
        clockText.text = timeString;

        // Get the current date
        DateTime currentDate = DateTime.Now;

        // Format the date (dd/mm/yyyy)
        string dateString = currentDate.ToString("dd/MM/yyyy");

        // Update the Text component with the current date
        dateText.text = dateString;
    }
}
