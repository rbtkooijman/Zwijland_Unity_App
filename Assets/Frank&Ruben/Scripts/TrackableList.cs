using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Vuforia;

public class TrackableList : MonoBehaviour {
 
    // Create variable to store world value in
    public float worldValue;

    // Update is called once per frame
    void Update () {

        // Get the StateManager
        StateManager sm = TrackerManager.Instance.GetStateManager ();
 
        // Query the StateManager to retrieve the list of currently 'active' trackables 
        IEnumerable<TrackableBehaviour> activeTrackables = sm.GetActiveTrackableBehaviours ();
 
        // Iterate through the list of active trackables and display in console
        Debug.Log ("List of trackables currently active (tracked): ");
        int numFrameMarkers = 0;

		// Create variable to store increasing world value in
		float valueCount = 10f;

        foreach (TrackableBehaviour tb in activeTrackables) {
            Debug.Log("Trackable: " + tb.TrackableName);
 
            if (tb is MarkerBehaviour)
                numFrameMarkers++;

                // Increase world value with every frame marker detected
                valueCount += 7.5f;
        }
 
        // If 'valueCount' is greater than 'worldValue', place world value count in the public 'worldValue' variable to be used by the interface
       	if (worldValue < valueCount) {
       		worldValue += 7.5f;
       	}

       	// Display the number of detected markers, the value count and the translated world value in the console
        Debug.Log ("Found " + numFrameMarkers + " frame markers in current frame.");
        Debug.Log ("Value count: " + valueCount);
        Debug.Log ("World value: " + worldValue + "%");    
    }
}