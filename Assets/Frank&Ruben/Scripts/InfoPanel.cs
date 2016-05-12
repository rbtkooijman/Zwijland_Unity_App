using UnityEngine;
using System.Collections;

public class InfoPanel : MonoBehaviour {

	// Create boolean to remember if the info panel is open or not
	public bool PanelOpened;

	public void ToggleInfoPanel () {

		if (PanelOpened == false) {
			GameObject.Find("InfoPanel").GetComponent<RectTransform>().sizeDelta = new Vector2(990f, 1350f);	

			// animation.Play("OpenInfoPanel");

			PanelOpened = true;	
		}

		else {
			GameObject.Find("InfoPanel").GetComponent<RectTransform>().sizeDelta = new Vector2(0f, 0f);

			// animation.Play("CloseInfoPanel");

			PanelOpened = false;
		}


	}
}
