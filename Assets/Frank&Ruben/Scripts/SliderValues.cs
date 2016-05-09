using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SliderValues : MonoBehaviour 
{

	// Update is called once per frame
    void Update () {

        // Round the values down to a whole number and palce them in variables to be used in the user interface

        // World value
        float worldRounded = Mathf.Floor(GameObject.Find("ARCamera").GetComponent<TrackableList>().worldValue);

        // // Geography value
        // float geoRounded = Mathf.Floor(GameObject.Find("ARCamera").GetComponent<TrackableList>().geoValue);

        // // History value
        // float histRounded = Mathf.Floor(GameObject.Find("ARCamera").GetComponent<TrackableList>().histValue);

        // // Nature value
        // float natRounded = Mathf.Floor(GameObject.Find("ARCamera").GetComponent<TrackableList>().natValue);

        // // Technology value
        // float techRounded = Mathf.Floor(GameObject.Find("ARCamera").GetComponent<TrackableList>().techValue);

    	// Update values of the UI slider elements with the value of the amount of detected frame markers in 'TrackableList.cs'
        
        // Place the world value in the world slider object
        GameObject.Find("WorldSlider").GetComponent<Slider>().value = GameObject.Find("ARCamera").GetComponent<TrackableList>().worldValue;

            // Place the rounded world value in the world percentage text label
            GameObject.Find("WorldPercentLabel").GetComponent<Text>().text = worldRounded + "%";
   	
        // VALUE: GEOGRAPHY
		GameObject.Find("GeoSlider").GetComponent<Slider>().value = GameObject.Find("ARCamera").GetComponent<TrackableList>().geoValue;

    	// VALUE HISTORY
		GameObject.Find("HistSlider").GetComponent<Slider>().value = GameObject.Find("ARCamera").GetComponent<TrackableList>().histValue;
    
		// VALUE: NATURE
		GameObject.Find("NatSlider").GetComponent<Slider>().value = GameObject.Find("ARCamera").GetComponent<TrackableList>().natValue;

		// VALUE: TECHNOLOGY
		GameObject.Find("TechSlider").GetComponent<Slider>().value = GameObject.Find("ARCamera").GetComponent<TrackableList>().techValue;
    }
}