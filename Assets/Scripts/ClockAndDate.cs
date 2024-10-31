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

    // Input fields for hours and minutes
    public TMP_InputField hourInput;
    public TMP_InputField minuteInput;

    // Reference to the object you want to enable/disable
    public GameObject objectSolution;
    public GameObject disableTipOne;
    public GameObject disableTipTwo;

    // Button to set the time
    public Button setTimeButton;

    private DateTime currentTime;

    void Start()
    {
        currentTime = DateTime.Now;

        // Set up the button click event
        setTimeButton.onClick.AddListener(UpdateClockTime);
    }

    void Update()
    {
        // Format the time (HH:mm)
        string timeString = currentTime.ToString("HH:mm");

        // Update the Text to current time
        clockText.text = timeString;

        // Get the current date
        DateTime currentDate = DateTime.Now;

        // Format the date (dd/mm/yyyy)
        string dateString = currentDate.ToString("dd/MM/yyyy");

        // Update the Text to current date
        dateText.text = dateString;

        // Enable or disable the object based on the time range
        CheckTimeRange();
    }

    // Method to update the clock time based on player input
    public void UpdateClockTime()
    {
        int hours, minutes, seconds;

        if (!int.TryParse(hourInput.text, out hours))
        {
            hours = currentTime.Hour;
        }

        if (!int.TryParse(minuteInput.text, out minutes))
        {
            minutes = currentTime.Minute;
        }

        if(!int.TryParse(minuteInput.text, out seconds))
        {
            minutes = currentTime.Minute;
        }

        // Set the new time based on player input
        currentTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, hours, minutes, seconds);
    }

    private void CheckTimeRange()
    {
        // Check if the time is between 00:00 and 04:00
        if (currentTime.Hour >= 0 && currentTime.Hour < 04)
        {
            // Enable the object
            objectSolution.SetActive(true);
            disableTipOne.SetActive(false);
            disableTipTwo.SetActive(false);
        }
        else
        {
            // Disable the object
            objectSolution.SetActive(false);
        }
    }

}
