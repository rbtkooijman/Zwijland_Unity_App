// Code by Ruben Kooijman
// http://rubenkooijman.nl

using UnityEngine;
using System.Collections;

public class CloseOnTouch : MonoBehaviour {

	public void TouchClose () {

		// Close the infopanel with animation if openend 
		if (GameObject.Find("InfoPanel").GetComponent<InfoPanel>().PanelOpened == true) {
			// GameObject.Find("InfoPanel").GetComponent<RectTransform>().sizeDelta = new Vector2(0f, 0f);

			// Play panel close animation
			GameObject.Find("InfoPanel").GetComponent<InfoPanel>().animPanel.Play("CloseInfoPanel");

			// Play button switch animation
			GameObject.Find("InfoPanel").GetComponent<InfoPanel>().animButton.Play("CloseToOpenInfoButton");

			// Set info panel state to 'closed'
			GameObject.Find("InfoPanel").GetComponent<InfoPanel>().PanelOpened = false;
		}

		// Hide the Geography complete banner with animation if visible
		if (GameObject.Find("UICanvas").GetComponent<SliderValues>().geoCompleteVisible == true) {

			// Play complete banner hide animation
			GameObject.Find("UICanvas").GetComponent<SliderValues>().animGeoBanner.Play("HideCompleteBanner");

			// Set Geography complete banner state to 'closed'
			GameObject.Find("UICanvas").GetComponent<SliderValues>().geoCompleteClosed = true;

			// Set Geography complete banner state to 'no longer visible'
			GameObject.Find("UICanvas").GetComponent<SliderValues>().geoCompleteVisible = false;
		}

		// Hide the History complete banner with animation if visible
		if (GameObject.Find("UICanvas").GetComponent<SliderValues>().histCompleteVisible == true) {

			// Play complete banner hide animation
			GameObject.Find("UICanvas").GetComponent<SliderValues>().animHistBanner.Play("HideCompleteBanner");

			// Set History complete banner state to 'closed'
			GameObject.Find("UICanvas").GetComponent<SliderValues>().histCompleteClosed = true;

			// Set History complete banner state to 'no longer visible'
			GameObject.Find("UICanvas").GetComponent<SliderValues>().histCompleteVisible = false;			
		}

		// Hide the Nature complete banner with animation if visible
		if (GameObject.Find("UICanvas").GetComponent<SliderValues>().natCompleteVisible == true) {

			// Play complete banner hide animation
			GameObject.Find("UICanvas").GetComponent<SliderValues>().animNatBanner.Play("HideCompleteBanner");

			// Set Nature complete banner state to 'closed'
			GameObject.Find("UICanvas").GetComponent<SliderValues>().natCompleteClosed = true;

			// Set Nature complete banner state to 'no longer visible'
			GameObject.Find("UICanvas").GetComponent<SliderValues>().natCompleteVisible = false;				
		}

		// Hide the Technology complete banner with animation if visible
		if (GameObject.Find("UICanvas").GetComponent<SliderValues>().techCompleteVisible == true) {

			// Play complete banner hide animation
			GameObject.Find("UICanvas").GetComponent<SliderValues>().animTechBanner.Play("HideCompleteBanner");

			// Set Technology complete banner state to 'closed'
			GameObject.Find("UICanvas").GetComponent<SliderValues>().techCompleteClosed = true;

			// Set Technology complete banner state to 'no longer visible'
			GameObject.Find("UICanvas").GetComponent<SliderValues>().techCompleteVisible = false;				
		}

		// Hide the World complete banner with animation if visible
		if (GameObject.Find("UICanvas").GetComponent<SliderValues>().worldCompleteVisible == true) {

			// Play complete banner hide animation
			GameObject.Find("UICanvas").GetComponent<SliderValues>().animWorldBanner.Play("HideWorldCompleteBanner");

			// Set World complete banner state to 'closed'
			GameObject.Find("UICanvas").GetComponent<SliderValues>().worldCompleteClosed = true;

			// Set World complete banner state to 'no longer visible'
			GameObject.Find("UICanvas").GetComponent<SliderValues>().worldCompleteVisible = false;
		}		
	}
}