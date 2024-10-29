using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Calculator : MonoBehaviour
{
    public TextMeshProUGUI displaytext;

    private string currentInput = "";
    private double result = 0.0;
    private int code = 7011;

    public void OnButtonClick(string buttonValue)
    {
        if (buttonValue == "=")
        {
            CalculateResult();
        }
        else if (buttonValue == "C")
        {
            ClearInput();
        }
        else
        {
            currentInput += buttonValue;
            UpdateDisplay();
        }
    }

    public void CalculateResult()
    {
        try
        {
            result = System.Convert.ToDouble(new System.Data.DataTable().Compute(currentInput, ""));
            currentInput = result.ToString();
            UpdateDisplay();

            if (code == result)
            {
                Debug.Log("Code is correct!");
                //Run end event method
            }
            else 
            {
                Debug.Log("Code is WRONG!");
            }
        }
        catch (System.Exception)
        {
            currentInput = "Error";
            UpdateDisplay();
        }
    }

    private void ClearInput()
    {
        currentInput = "";
        result = 0.0;
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        displaytext.text = currentInput;
    }
}


