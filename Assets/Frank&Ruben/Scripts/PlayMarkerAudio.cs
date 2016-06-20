using UnityEngine;
using System.Collections;
using Vuforia;

public class PlayMarkerAudio : MonoBehaviour, ITrackableEventHandler {

    private TrackableBehaviour mTrackableBehaviour;

    // Create reference to the animator component for FrameMarker8's animation resets
    private Animator animWhale;

	// Use this for initialization
	void Start () {

        // Get the animator component of the Whale object for FrameMarker8's animation resets
        animWhale = GameObject.Find("Whale").GetComponent<Animator>();
        
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();

        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
	}

	public void OnTrackableStateChanged(
		TrackableBehaviour.Status previousStatus,
		TrackableBehaviour.Status newStatus)
    {

		AudioSource audio = GetComponent<AudioSource>();

        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {

            // Play audio when target is found
            audio.Play();

            // Check if the detected marker is FrameMarker8 (Whale)
            if (mTrackableBehaviour.TrackableName == "FrameMarker8") {

                // Play the Whale animation
                animWhale.Play("WhaleAnimation");
            }

            // Check if the detected marker is ImageTarget_Card (Reward)
            if (mTrackableBehaviour.TrackableName == "ImageTarget_Card") {

                Debug.Log ("Reward card found!");

                // Hide the interface canvas when ImageTarget_Card is found
                GameObject.Find("UICanvas").GetComponent<CanvasGroup>().alpha = 0;

                // Disable interface input while the interface is hidden
                GameObject.Find("UICanvas").GetComponent<CanvasGroup>().interactable = false;             
            }            
        }
        else
        {
            // Stop audio when target is lost
            audio.Stop();

            // Check if the detected marker is FrameMarker8 (Whale)
            if (mTrackableBehaviour.TrackableName == "FrameMarker8") {
                
                // Stop the Whale animation
                animWhale.Play("Idle");
            }

            // // Check if the detected marker is ImageTarget_Card (Reward)
            if (mTrackableBehaviour.TrackableName == "ImageTarget_Card") {

                Debug.Log ("Reward card lost!");

                // Show the interface canvas when ImageTarget_Card is found
                GameObject.Find("UICanvas").GetComponent<CanvasGroup>().alpha = 1;

                // Re-enable interface input while the interface is visible
                GameObject.Find("UICanvas").GetComponent<CanvasGroup>().interactable = true;
            }              
        }
    }
}