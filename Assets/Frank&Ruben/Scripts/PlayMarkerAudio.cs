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
        }
    }
}