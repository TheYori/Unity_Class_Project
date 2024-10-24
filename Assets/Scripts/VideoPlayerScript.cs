using UnityEngine;
using UnityEngine.Video;  // Required for using the VideoPlayer component

public class VideoTrigger : MonoBehaviour
{
    private VideoPlayer videoPlayer;
    public GameObject screen;

    // Start is called before the first frame update
    void Start()
    {
        // Get the VideoPlayer component attached to this GameObject
        videoPlayer = GetComponent<VideoPlayer>();

        // Ensure the video doesn't play on start
        videoPlayer.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (screen == null)
           {
               //Debug.Log("GameObject has been destroyed, stopping Update()");
                return; // Exit the Update() loop
           }
        // Check if Screen is active, then play video
        if (screen.activeInHierarchy == true)
        {
            PlayVideo();
            return;
        }

        //if (screen.activeInHierarchy == true && timeElapsed)
    }

    // Method to play the video
    void PlayVideo()
    {
        if (videoPlayer != null && !videoPlayer.isPlaying)
        {
            videoPlayer.Play();
            //Debug.Log("Video is now playing");
        }
    }
}
