using System;
using System.Collections;
using UnityEngine;

public class LoadingBarEventTrigger : MonoBehaviour
{
    public GameObject LoadingBar;
    public event Action OnTaskCompleted;

    void Start()
    {
        Debug.Log("ScriptA has started. Starting PerformTask coroutine...");
        StartCoroutine(PerformTask());
    }

    public void whenButtonClicked()
    {
        if (!LoadingBar.activeInHierarchy)
        {
            LoadingBar.SetActive(true);
            StartCoroutine(RemoveAfterSeconds());
        }
    }

    private IEnumerator PerformTask()
    {
        Debug.Log("ScriptA is performing its task...");
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

    private IEnumerator RemoveAfterSeconds()
    {
        Debug.Log("LoadingBar hides in 10 seconds");
        yield return new WaitForSeconds(8);

        Debug.Log("LoadingBar is hidden");
        LoadingBar.SetActive(false);
    }
}





//Gammel trigger i forbindelse med Animator - Var ikke nødvendig, men godt at dokumentere
    /*{
        mAnimator = GetComponent<Animator>();
        Debug.Log("Script has started!"); // Check if script starts
        GameObject.setActive();

        if (mAnimator == null)
        {
            Debug.LogError("Animator not found!"); // Error if Animator isn't attached
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (mAnimator == null)
        {
            Debug.LogError("Animator is null!");
            return;
        }

        if (Input.GetKeyDown(KeyCode.K))
        {   
            Debug.Log("K key pressed, playing animation!");
            mAnimator.SetTrigger("TriggerTest");
            GameObject.setActive();
            Destroy (gameObject, 5.0f);
        }
        
    }*/