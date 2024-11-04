using System;
using System.Collections;
using UnityEngine;

public class LoadingBarEventTrigger : MonoBehaviour
{
    public GameObject LoadingBar;
    public event Action OnTaskCompleted;

    void Start()
    {
        //Debug.Log("ScriptA has started. Starting PerformTask coroutine...");
        StartCoroutine(PerformTask());
    }

    //Når knappen er trykket - Starter video og countdown
    public void whenButtonClicked()
    {
        if (!LoadingBar.activeInHierarchy)
        {
            LoadingBar.SetActive(true);
            StartCoroutine(RemoveAfterSeconds());
        }
    }

    //Aktivere OnTaskCompletedEvent
    private IEnumerator PerformTask()
    {
        //Debug.Log("ScriptA is performing its task...");
        yield return new WaitForSeconds(9);  // Simulate delay

        Debug.Log("ScriptA has completed its task!");
        
        if (OnTaskCompleted != null)
        {
            Debug.Log("Triggering OnTaskCompleted event in ScriptA.");
            OnTaskCompleted.Invoke();
        }
        else
        {
            Debug.LogWarning("No subscribers to OnTaskCompleted event in ScriptA.");
        }
    }
    //Gemmer LoadingBar efter den er færdig med at spille
    private IEnumerator RemoveAfterSeconds()
    {
        //Debug.Log("LoadingBar hides in 8 seconds");
        yield return new WaitForSeconds(8);

        Debug.Log("LoadingBar is hidden");
        LoadingBar.SetActive(false);
    }
}