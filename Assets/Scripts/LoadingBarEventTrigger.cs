using System.Collections;
using UnityEngine;

public class DelayedAnimation : MonoBehaviour
{
    public Animator animator; // Reference to the Animator component
    public string animationTriggerName = "PlayAnimation"; // The name of the trigger in the Animator
    public float delayTime = 2.0f; // The delay time in seconds after the event

    // This function will be called when the event is triggered
    public void TriggerEvent()
    {
        // Start the coroutine to wait and play the animation after the delay
        StartCoroutine(PlayAnimationAfterDelay());
    }

    // Coroutine to handle the delay before playing the animation
    IEnumerator PlayAnimationAfterDelay()
    {
        // Wait for the specified amount of time
        yield return new WaitForSeconds(delayTime);

        // Trigger the animation after the delay
        animator.SetTrigger(animationTriggerName);
    }
}

