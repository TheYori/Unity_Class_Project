using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingBarEventTrigger : MonoBehaviour
{
    public GameObject LoadingBar;
    public event Action OnTaskCompleted;  // Fix: Add Action delegate for event

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PerformTask());
    }
    
    void Update()
    {
        // No need for return statement in Update()
    }

    public void whenButtonClicked()
    {
        if (LoadingBar.activeInHierarchy == false)
        {
            LoadingBar.SetActive(true);
        }

        if (LoadingBar.activeInHierarchy == true)
        {
            transform.position = new Vector3(1000, 1000, 1000);  // Move it far away
;
        }
    }

    private IEnumerator PerformTask()
    {
        Debug.Log("ScriptA is performing its task...");
        yield return new WaitForSeconds(3);  // Simulate a delay

        Debug.Log("ScriptA has completed its task!");

        // Trigger the event
        OnTaskCompleted?.Invoke();
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