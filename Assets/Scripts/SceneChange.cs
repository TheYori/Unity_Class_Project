// AUTHOUR: Ricki G. Matwijkiw
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
   // Changes scene when the "connect" button is pressed
   // This method is assigned to an OnClick()
    public void ChangeScene(string PrimaryScene)
    {
        SceneManager.LoadScene(PrimaryScene);
    }
}
