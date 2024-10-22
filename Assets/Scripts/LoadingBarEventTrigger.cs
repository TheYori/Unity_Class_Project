using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedAnimation : MonoBehaviour
{
    private Animator mAnimator;

    // Start is called before the first frame update
    void Start()
    {
        mAnimator = GetComponent<Animator>();
        Debug.Log("Script has started!"); // Check if script starts

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
        }
    }
}