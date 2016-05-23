using UnityEngine;
using System.Collections;

public class CloseOnTouch : MonoBehaviour {

	// Create references to the animator components
	public Animator animPanel;

	public Animator animButton;

	void Update () {

		animPanel = GameObject.Find("InfoPanel").GetComponent<Animator>();

		animButton = GameObject.Find("InfoButton").GetComponent<Animator>();		
	}

	public void TouchClose () {

		// Close the infopanel with animation if openend 
		if (GameObject.Find("InfoPanel").GetComponent<InfoPanel>().PanelOpened == true) {
			// GameObject.Find("InfoPanel").GetComponent<RectTransform>().sizeDelta = new Vector2(0f, 0f);

			// Play panel close animation
			animPanel.Play("CloseInfoPanel");

			// Play button switch animation
			animButton.Play("CloseToOpenInfoButton");

			// Set info panel state to 'closed'
			GameObject.Find("InfoPanel").GetComponent<InfoPanel>().PanelOpened = false;
		}

		// Hide the Geography complete banner with animation if visible
		if (GameObject.Find("ARCamera").GetComponent<TrackableList>().GeoCompleteVisible == true) {

			// Play panel hide animation
			GameObject.Find("ARCamera").GetComponent<TrackableList>().animGeoBanner.Play("HideCompleteBanner");

			// Set Geography complete banner state to 'hidden'
			GameObject.Find("ARCamera").GetComponent<TrackableList>().GeoCompleteVisible = false;
		}		

	}

}