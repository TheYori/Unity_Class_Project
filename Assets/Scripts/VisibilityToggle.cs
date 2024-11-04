// AUTHOUR: Ricki G. Matwijkiw
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.Security.Cryptography.X509Certificates;

public class VisibilityToggle : MonoBehaviour
{
    public GameObject specificObject; //Object we want to open and close when clicking.
    public GameObject objectToDisable; //Object we want to close - Specifically used for closing Windows' Start Menu.


     public void Visibility()
    {
        if (specificObject != null)
        {
            // Toggle the active state of the object
            bool isActive = specificObject.activeSelf;
            specificObject.SetActive(!isActive);
            objectToDisable.SetActive(false);

            // Additional logic for opening the app goes here
            Debug.Log("APP OPEN");
        }
    }
}
