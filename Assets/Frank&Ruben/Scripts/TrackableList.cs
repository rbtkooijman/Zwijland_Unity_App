using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Vuforia;

public class TrackableList : MonoBehaviour {
 
    // Update is called once per frame
    void Update () {
        // Get the StateManager
        StateManager sm = TrackerManager.Instance.GetStateManager ();
 
        // Query the StateManager to retrieve the list of
        // currently 'active' trackables 
        //(i.e. the ones currently being tracked by Vuforia)
        IEnumerable<TrackableBehaviour> activeTrackables = sm.GetActiveTrackableBehaviours ();
 
        // Iterate through the list of active trackables
        Debug.Log ("List of trackables currently active (tracked): ");
        int numFrameMarkers = 0;

        decimal worldValue = 10;

        foreach (TrackableBehaviour tb in activeTrackables) {
            Debug.Log("Trackable: " + tb.TrackableName);
 
            if (tb is MarkerBehaviour)
                numFrameMarkers++;

                // Increase world value with every frame marker detected
                worldValue+=7.5;
        }
 
        Debug.Log ("Found " + numFrameMarkers + " frame markers in current frame.");
        Debug.Log ("World value: " + worldValue + "%.");
    }
}