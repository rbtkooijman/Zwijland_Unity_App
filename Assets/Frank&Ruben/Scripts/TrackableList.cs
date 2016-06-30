// Code by Ruben Kooijman
// http://rubenkooijman.nl

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Vuforia;

public class TrackableList : MonoBehaviour {

	// Create variable for the total amount of markers used in the application
	public static float markerAmount = 12;

	// Create a variable for the amount of markers per category (in this case: 12 / 4)
	public static float markerAmountCategory = markerAmount / 4;

	// Create a variable for value per marker (in this case: 100% / 12)
	public float markerValue = 100 / markerAmount;

	// Create a variable for value per marker (in this case: 100% / 4)
	public float markerValueCategory = 100 / markerAmountCategory;

    // Create public variables to store world and theme values in
    public float worldValue, geoValue, histValue, natValue, techValue;

    // Create booleans to remember if individual markers have been tracked already
    public bool marker0Tracked, marker1Tracked, marker2Tracked, marker3Tracked, marker4Tracked, marker5Tracked, marker6Tracked, marker7Tracked, marker8Tracked, marker9Tracked, marker10Tracked, marker11Tracked; 

    // Update is called once per frame
    void Update () {

        // Get the StateManager
        StateManager sm = TrackerManager.Instance.GetStateManager ();
 
        // Query the StateManager to retrieve the list of currently 'active' trackables 
        IEnumerable<TrackableBehaviour> activeTrackables = sm.GetActiveTrackableBehaviours ();
 
        // Iterate through the list of active trackables and display in console
        // Debug.Log ("List of trackables currently active (tracked): ");
        int numFrameMarkers = 0;

		// Run this for every marker tracked
        foreach (TrackableBehaviour tb in activeTrackables) {
            // Debug.Log("Trackable: " + tb.TrackableName);
 
 			// Increase count for every frame marker tracked
            if (tb is MarkerBehaviour) {
                numFrameMarkers++;
            }

            // Create variable with marker name to use in switch statement
            string markerName = tb.TrackableName;

		    // Check if individual markers are tracked and increase world/individual values when detected
            switch (markerName) {
            	
            	// If "FrameMarker0" has been detected
            	case "FrameMarker0":

			    	if (marker0Tracked == false) { // Check if marker 0 has been detected before
			    		geoValue += markerValueCategory; // Increase the geography category value with amount equal to value per marker
			    		worldValue += markerValue; // Increase the world value with the amount equal to value per marker

			    		marker0Tracked = true; // Marker 0 has been detected (no value increase on future detections)
			    	}
			    	
			    	break;

			    case "FrameMarker1":

			    	if (marker1Tracked == false) {
			    		geoValue += markerValueCategory;
			    		worldValue += markerValue;

			    		marker1Tracked = true;
			    	}
			    	
			    	break;

			    case "FrameMarker2":

			    	if (marker2Tracked == false) {
			    		geoValue += markerValueCategory;
			    		worldValue += markerValue;

			    		marker2Tracked = true;
			    	}
			    	
			    	break;

			    case "FrameMarker3":

			    	if (marker3Tracked == false) {
			    		histValue += markerValueCategory;
			    		worldValue += markerValue;

			    		marker3Tracked = true;
			    	}
			    	
			    	break;

			    case "FrameMarker4":

			    	if (marker4Tracked == false) {
			    		histValue += markerValueCategory;
			    		worldValue += markerValue;

			    		marker4Tracked = true;
			    	}
			    	
			    	break;

			    case "FrameMarker5":

			    	if (marker5Tracked == false) {
			    		histValue += markerValueCategory;
			    		worldValue += markerValue;

			    		marker5Tracked = true;
			    	}
			    	
			    	break;

			    case "FrameMarker6":

			    	if (marker6Tracked == false) {
			    		natValue += markerValueCategory;
			    		worldValue += markerValue;

			    		marker6Tracked = true;
			    	}

			    	break;

			    case "FrameMarker7":

			    	if (marker7Tracked == false) {
			    		natValue += markerValueCategory;
			    		worldValue += markerValue;

			    		marker7Tracked = true;
			    	}

			    	break;

			    case "FrameMarker8":

			    	if (marker8Tracked == false) {
			    		natValue += markerValueCategory;
			    		worldValue += markerValue;

			    		marker8Tracked = true;
			    	}

			    	break;

			    case "FrameMarker9":

			    	if (marker9Tracked == false) {
			    		techValue += markerValueCategory;
			    		worldValue += markerValue;

			    		marker9Tracked = true;
			    	}

			    	break;
			    
			    case "FrameMarker10":

			    	if (marker10Tracked == false) {
			    		techValue += markerValueCategory;
			    		worldValue += markerValue;

			    		marker10Tracked = true;
			    	}

			    	break;

			    case "FrameMarker11":

			    	if (marker11Tracked == false) {
			    		techValue += markerValueCategory;
			    		worldValue += markerValue;

			    		marker11Tracked = true;
			    	}

			    	break;	    	
			}
		}

       	// Display the number of detected markers and the world/category values in the console
        // Debug.Log ("Found " + numFrameMarkers + " frame markers in current frame.");
        // Debug.Log ("World value: " + worldValue + "%");
        // Debug.Log ("Geography value: " + geoValue + "%");
        // Debug.Log ("History value: " + histValue + "%");
        // Debug.Log ("Nature value: " + natValue + "%");
        // Debug.Log ("Technology value: " + techValue + "%");
    }
}