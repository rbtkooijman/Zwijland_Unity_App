// Code by Ruben Kooijman
// http://rubenkooijman.nl

using UnityEngine;
using System.Collections;

// Enable the 'back' button on the device to exit the app 
public class BackButton : MonoBehaviour {

	// Update is called once per frame
	void Update () {
	   	if (Input.GetKeyDown(KeyCode.Escape)) 
	    Application.Quit();
	}
}