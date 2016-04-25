using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Vuforia;

public class TrackableList : MonoBehaviour {

	// Use this for initialization
	// void Start () {
	
	// }
	
	// Update is called once per frame
	void Update () {
	    // Get the StateManager
	    StateManager sm = TrackerManager.Instance.GetStateManager ();
	 
	    // Query the StateManager to retrieve the list of
	    // currently 'active' trackables 
	    //(i.e. the ones currently being tracked by Vuforia)
	    IEnumerable<TrackableBehaviour> activeTrackables = sm.GetActiveTrackableBehaviours ();
	    foreach (TrackableBehaviour tb in activeTrackables) {
	        string trackableName = tb.TrackableName;
	             
	        Transform augmentationChild = tb.gameObject.transform.FindChild("myAugmentation");
	        if (augmentationChild == null) {
	            // this trackable has not been augmented yet
	            // so, let's add an augmentation object
	            GameObject myAugmentation = GameObject.CreatePrimitive(PrimitiveType.Cube);
	            myAugmentation.name = "myAugmentation";
	 
	            // Attach our augmentation object to the trackable
	            myAugmentation.transform.parent = tb.transform;
	 
	            // Adjust local scale and position
	            // so that the cube is centered aon the target
	            myAugmentation.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
	            myAugmentation.transform.localPosition = new Vector3(0.0f, 0.25f, 0.0f);
	            myAugmentation.transform.localRotation = Quaternion.identity;
	            myAugmentation.SetActive(true);
	        }
	    }
	}
}
