using UnityEngine;
using System.Collections;

public class InfoPanel : MonoBehaviour {

	// Create boolean to remember if the info panel is open or not
	public bool PanelOpened;

	// Create references to the animator components
	private Animator animPanel;

	private Animator animButton;	

	void Update () {

		animPanel = GetComponent<Animator>();

		animButton = GameObject.Find("InfoButton").GetComponent<Animator>();		
	}

	public void ToggleInfoPanel () {

		if (PanelOpened == false) {
			// GameObject.Find("InfoPanel").GetComponent<RectTransform>().sizeDelta = new Vector2(990f, 1350f);	

			// Play panel open animation
			animPanel.Play ("OpenInfoPanel");

			// Play button switch animation
			animButton.Play ("OpenToCloseInfoButton");

			PanelOpened = true;
		}

		else {
			// GameObject.Find("InfoPanel").GetComponent<RectTransform>().sizeDelta = new Vector2(0f, 0f);

			// Play panel close animation
			animPanel.Play ("CloseInfoPanel");

			// Play button switch animation
			animButton.Play ("CloseToOpenInfoButton");

			PanelOpened = false;
		}

	}

}
