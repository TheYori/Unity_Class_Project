using System.Collections;
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
}
