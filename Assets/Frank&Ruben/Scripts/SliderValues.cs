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

        // Geography value
        float geoRounded = Mathf.Floor(GameObject.Find("ARCamera").GetComponent<TrackableList>().geoValue);

        // History value
        float histRounded = Mathf.Floor(GameObject.Find("ARCamera").GetComponent<TrackableList>().histValue);

        // Nature value
        float natRounded = Mathf.Floor(GameObject.Find("ARCamera").GetComponent<TrackableList>().natValue);

        // Technology value
        float techRounded = Mathf.Floor(GameObject.Find("ARCamera").GetComponent<TrackableList>().techValue);

    	// Update values of the UI slider elements with the value of the amount of detected frame markers in 'TrackableList.cs'
        
        // Place the world value in the world slider object
        GameObject.Find("WorldSlider").GetComponent<Slider>().value = GameObject.Find("ARCamera").GetComponent<TrackableList>().worldValue;

            // Place the rounded world value in the world percentage text label
            GameObject.Find("WorldPercentLabel").GetComponent<Text>().text = worldRounded + "%";
   	
        // Place the geography value in the respective slider object
		GameObject.Find("GeoSlider").GetComponent<Slider>().value = GameObject.Find("ARCamera").GetComponent<TrackableList>().geoValue;

            // Place the rounded geography value in the geography percentage text label
            GameObject.Find("GeoPercentLabel").GetComponent<Text>().text = geoRounded + "%";        

        // Place the history value in the respective slider object
		GameObject.Find("HistSlider").GetComponent<Slider>().value = GameObject.Find("ARCamera").GetComponent<TrackableList>().histValue;

            // Place the rounded history value in the history percentage text label
            GameObject.Find("HistPercentLabel").GetComponent<Text>().text = histRounded + "%";          
    
        // Place the nature value in the respective slider object
		GameObject.Find("NatSlider").GetComponent<Slider>().value = GameObject.Find("ARCamera").GetComponent<TrackableList>().natValue;

            // Place the rounded nature value in the nature percentage text label
            GameObject.Find("NatPercentLabel").GetComponent<Text>().text = natRounded + "%";  

        // Place the technology value in the respective slider object
		GameObject.Find("TechSlider").GetComponent<Slider>().value = GameObject.Find("ARCamera").GetComponent<TrackableList>().techValue;

            // Place the rounded technology value in the technology percentage text label
            GameObject.Find("TechPercentLabel").GetComponent<Text>().text = techRounded + "%";  
    }
}