using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipChanger : MonoBehaviour
{
    public GameObject disableObject;
    public GameObject enableObject;

    // Start is called before the first frame update
    public void ChangeTip()
    {
        disableObject.SetActive(false);
        enableObject.SetActive(true);
    }
}
