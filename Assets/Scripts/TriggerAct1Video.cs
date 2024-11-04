using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using System.Collections;

public class TriggerAct1Video : MonoBehaviour
{
    public GameObject Act1Video;
    private RawImage rawImageComponent;
    private VideoPlayer videoPlayerComponent;

    void Start()
    {
        // Get RawImage and VideoPlayer components from Act1Video
        rawImageComponent = Act1Video != null ? Act1Video.GetComponent<RawImage>() : null;
        videoPlayerComponent = Act1Video != null ? Act1Video.GetComponent<VideoPlayer>() : null;

        if (rawImageComponent != null && videoPlayerComponent != null)
        {
            // Make the video invisible initially by setting the RawImage alpha to 0
            SetAlpha(0f);
        }
        else
        {
            Debug.LogWarning("Act1Video is missing a RawImage or VideoPlayer component.");
        }

        // Find ScriptA and subscribe to its event
        LoadingBarEventTrigger scriptA = FindObjectOfType<LoadingBarEventTrigger>();
        if (scriptA != null)
        {
            scriptA.OnTaskCompleted += ActivateScript;
        }
    }

    private void SetAlpha(float alpha)
    {
        if (rawImageComponent != null)
        {
            var color = rawImageComponent.color;
            color.a = alpha;
            rawImageComponent.color = color;
        }
    }

    public void ActivateScript()
    {
        Debug.Log("ActivateScript called in ScriptB!");

        if (rawImageComponent != null && videoPlayerComponent != null)
        {
            // Make the RawImage visible
            SetAlpha(1f);

            // Play the video
            videoPlayerComponent.Play();
            
            // Deactivate after 5 seconds
            StartCoroutine(DeactivateAfterTime(8.0f));
        }
        else
        {
            Debug.LogWarning("RawImage or VideoPlayer component is missing on Act1Video.");
        }
    }

    private IEnumerator DeactivateAfterTime(float delay)
    {
        yield return new WaitForSeconds(delay);

        // Stop the video and make the RawImage invisible
        if (videoPlayerComponent != null)
        {
            videoPlayerComponent.Stop();
        }

        SetAlpha(0f);
        Debug.Log("Act1Video has been deactivated.");
    }
}






/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAct1Video : MonoBehaviour
{
    public GameObject Act1Video;

    // Start is called before the first frame update
    void Start()
      {
        // Find ScriptA and subscribe to its OnTaskCompleted event
        LoadingBarEventTrigger scriptA = FindObjectOfType<LoadingBarEventTrigger>();

        if (scriptA != null)
        {
            scriptA.OnTaskCompleted += ActivateScript;  // Subscribe to the event
        }
        else
        {
            Debug.LogWarning("ScriptA not found. Make sure it is in the scene.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        return;
    }
    public void ActivateScript()
    {
        Debug.Log("ScriptB has been activated after ScriptA completed its task!");

        if(Act1Video.activeInHierarchy == false)
        {
            Act1Video.SetActive(true);
        }
            
        if(Act1Video.activeInHierarchy == true)
        {
            Destroy(Act1Video, 5.0f);
        }
            
    }
     private void OnDestroy()
    {
        // Clean up the event subscription to avoid memory leaks
       LoadingBarEventTrigger scriptA = FindObjectOfType<LoadingBarEventTrigger>();

        if (scriptA != null)
        {
            scriptA.OnTaskCompleted -= ActivateScript;
        }
    }
}*/
