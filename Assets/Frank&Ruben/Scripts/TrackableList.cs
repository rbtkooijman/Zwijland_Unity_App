using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Vuforia;

public class TrackableList : MonoBehaviour {

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
        Debug.Log ("List of trackables currently active (tracked): ");
        int numFrameMarkers = 0;

		// Create variable for the total amount of markers used in the application
		float markerAmount = 12f;

		// Create a variable for the amount of markers per category (in this case: 12 / 4)
		float markerAmountCategory = markerAmount / 4;

		// Create a variable for value per markers (in this case: 100% / 12)
		float markerValue = 100 / markerAmount;

		// Create a variable for value per markers (in this case: 100% /4)
		float markerValueCategory = 100 / markerAmountCategory;	

        foreach (TrackableBehaviour tb in activeTrackables) {
            Debug.Log("Trackable: " + tb.TrackableName);
 
            if (tb is MarkerBehaviour) {
                numFrameMarkers++;
            }

		    // Check individual markers and increase values if detected
		    if (tb.TrackableName.Equals("FrameMarker0")) {

		    	if (marker0Tracked == false) {
		    		geoValue += markerValueCategory;
		    		worldValue += markerValue;

		    		marker0Tracked = true;
		    	}
		    }

		    else if (tb.TrackableName.Equals("FrameMarker1")) {

		    	if (marker1Tracked == false) {
		    		geoValue += markerValueCategory;
		    		worldValue += markerValue;

		    		marker1Tracked = true;
		    	}
		    }
		    
		    else if (tb.TrackableName.Equals("FrameMarker2")) {

		    	if (marker2Tracked == false) {
		    		geoValue += markerValueCategory;
		    		worldValue += markerValue;

		    		marker2Tracked = true;
		    	}
		    }

		    else if (tb.TrackableName.Equals("FrameMarker3")) {

		    	if (marker3Tracked == false) {
		    		histValue += markerValueCategory;
		    		worldValue += markerValue;

		    		marker3Tracked = true;
		    	}
		    }

		    else if (tb.TrackableName.Equals("FrameMarker4")) {

		    	if (marker4Tracked == false) {
		    		histValue += markerValueCategory;
		    		worldValue += markerValue;

		    		marker4Tracked = true;
		    	}
		    }

		    else if (tb.TrackableName.Equals("FrameMarker5")) {

		    	if (marker5Tracked == false) {
		    		histValue += markerValueCategory;
		    		worldValue += markerValue;

		    		marker5Tracked = true;
		    	}
		    }

		    else if (tb.TrackableName.Equals("FrameMarker6")) {

		    	if (marker6Tracked == false) {
		    		natValue += markerValueCategory;
		    		worldValue += markerValue;

		    		marker6Tracked = true;
		    	}
		    }

		    else if (tb.TrackableName.Equals("FrameMarker7")) {

		    	if (marker7Tracked == false) {
		    		natValue += markerValueCategory;
		    		worldValue += markerValue;

		    		marker7Tracked = true;
		    	}
		    }

		    else if (tb.TrackableName.Equals("FrameMarker8")) {

		    	if (marker8Tracked == false) {
		    		natValue += markerValueCategory;
		    		worldValue += markerValue;

		    		marker8Tracked = true;
		    	}
		    }

		    else if (tb.TrackableName.Equals("FrameMarker9")) {

		    	if (marker9Tracked == false) {
		    		techValue += markerValueCategory;
		    		worldValue += markerValue;

		    		marker9Tracked = true;
		    	}
		    }

		    else if (tb.TrackableName.Equals("FrameMarker10")) {

		    	if (marker10Tracked == false) {
		    		techValue += markerValueCategory;
		    		worldValue += markerValue;

		    		marker10Tracked = true;
		    	}
		    }

		    else if (tb.TrackableName.Equals("FrameMarker11")) {

		    	if (marker11Tracked == false) {
		    		techValue += markerValueCategory;
		    		worldValue += markerValue;

		    		marker11Tracked = true;
		    	}
		    }		    		    		    		        		    		    	       
		}

       	// Display the number of detected markers, the value count and the translated world value in the console
        Debug.Log ("Found " + numFrameMarkers + " frame markers in current frame.");
        Debug.Log ("World value: " + worldValue + "%");
        Debug.Log ("Geography value: " + geoValue + "%");
        Debug.Log ("History value: " + histValue + "%");
        Debug.Log ("Nature value: " + natValue + "%");
        Debug.Log ("Technology value: " + techValue + "%");
    }
}