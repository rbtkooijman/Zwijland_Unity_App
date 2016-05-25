using UnityEngine;
using System.Collections;

public class InfoPanel : MonoBehaviour {

	// Create boolean to remember if the info panel is open or not
	public bool PanelOpened;

	// Create references to the animator components
	public Animator animPanel, animButton;

	// Create references to the audio components
    public AudioSource audioPanel;

	void Update () {

		// Store the object references to the animator components
		animPanel = GetComponent<Animator>();
		animButton = GameObject.Find("InfoButton").GetComponent<Animator>();
		
		// Store the object references to the audio component
        audioPanel = GameObject.Find("InfoButton").GetComponent<AudioSource>();		
	}

	public void ToggleInfoPanel () {

		if (PanelOpened == false) {
			
			// Play panel open animation
			animPanel.Play("OpenInfoPanel");

			// Play button switch animation
			animButton.Play("OpenToCloseInfoButton");

            // Play panel sound effect
            audioPanel.Play();

			// Set info panel state to 'opened'
			PanelOpened = true;
		}

		else {
			
			// Play panel close animation
			animPanel.Play("CloseInfoPanel");

			// Play button switch animation
			animButton.Play("CloseToOpenInfoButton");

            // Play panel sound effect
            audioPanel.Play();			

			// Set info panel state to 'closed'
			PanelOpened = false;
		}

	}

}
