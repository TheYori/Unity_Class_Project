// AUTHOUR: Ricki G. Matwijkiw
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipChanger : MonoBehaviour
{
    public GameObject disableObject;    //Object to disable
    public GameObject enableObject;     //Object to enable

    // Disables first tip and activates the second
    public void ChangeTip()
    {
        disableObject.SetActive(false);
        enableObject.SetActive(true);
    }
}
