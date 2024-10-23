using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingBarEventTrigger : MonoBehaviour
{
    private GameObject screen;

    // Start is called before the first frame update
    void Start()
    {

    }
    
    void Update()
    {
        
    }
    public void whenButtonClicked()
    {
        if(screen.activeInHierachy == false)
          screen.setActive(true);

        if(screen.activeInHierachy == true)
           Destroy (screen, 5.0f);
    }
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
}