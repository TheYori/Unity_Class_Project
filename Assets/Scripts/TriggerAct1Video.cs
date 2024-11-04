//AUTHOR: Clara Rosenkvist
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
        // RawImage og Videoplayer til Act1VideoGet 
        rawImageComponent = Act1Video != null ? Act1Video.GetComponent<RawImage>() : null;
        videoPlayerComponent = Act1Video != null ? Act1Video.GetComponent<VideoPlayer>() : null;

        if (rawImageComponent != null && videoPlayerComponent != null)
        {
            // RawImage Aplha til 0, for at skjulle den
            SetAlpha(0f);
        }
        else
        {
            Debug.LogWarning("Act1Video is missing a RawImage or VideoPlayer component.");
        }

        // Find LoadingBarEventTrigger = scriptA, og "subscribe" til dens event
        LoadingBarEventTrigger scriptA = FindObjectOfType<LoadingBarEventTrigger>();
        if (scriptA != null)
        {
            scriptA.OnTaskCompleted += ActivateScript;
        }
    }

    //invisible
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
            // RawImage synlig
            SetAlpha(1f);

            // Spil video
            videoPlayerComponent.Play();
            
            // Deactivate efter X antal sekunder (i forhold til hvor lang videoen er)
            StartCoroutine(DeactivateAfterTime(8.0f));
        }
        else
        {
            Debug.LogWarning("RawImage or VideoPlayer component is missing on Act1Video.");
        }
    }

    //Video usynlig når den er færdig med at spille
    private IEnumerator DeactivateAfterTime(float delay)
    {
        yield return new WaitForSeconds(delay);

        if (videoPlayerComponent != null)
        {
            videoPlayerComponent.Stop();
        }

        SetAlpha(0f);
        Debug.Log("Act1Video has been deactivated.");
    }
}