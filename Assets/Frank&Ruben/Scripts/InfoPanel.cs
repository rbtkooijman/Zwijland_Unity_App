using UnityEngine;
using System.Collections;

public class InfoPanel : MonoBehaviour {

	// Create boolean to remember if the info panel is open or not
	public bool PanelOpened;

	// Create reference to the animator component
	private Animator anim;

	void Update () {

		anim = GetComponent<Animator>();
	}

	public void ToggleInfoPanel () {

		if (PanelOpened == false) {
			// GameObject.Find("InfoPanel").GetComponent<RectTransform>().sizeDelta = new Vector2(990f, 1350f);	

			anim.Play ("OpenInfoPanel");

			PanelOpened = true;
		}

		else {
			// GameObject.Find("InfoPanel").GetComponent<RectTransform>().sizeDelta = new Vector2(0f, 0f);

			anim.Play ("CloseInfoPanel");

			PanelOpened = false;
		}

	}

}
