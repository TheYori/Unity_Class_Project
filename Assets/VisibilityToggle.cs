using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.Security.Cryptography.X509Certificates;

public class VisibilityToggle : MonoBehaviour
{
    public GameObject specificObject;
    

    public void Visibility()
    {
        if (specificObject != null)
        {
            // Toggle the active state of the object
            bool isActive = specificObject.activeSelf;
            specificObject.SetActive(!isActive);
        }



    }

    public void CloseObject()
    {
        specificObject.SetActive(false);
    }
}
