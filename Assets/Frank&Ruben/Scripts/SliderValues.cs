using UnityEngine;
using UnityEngine.UI;
using System.Collections;
 
public class SliderValues : MonoBehaviour 
{

	// Update is called once per frame
    void Update () {

    	// Update values of the UI slider elements with the value of the amount of detected frame markers in 'TrackableList.cs'
        
    	// World
        GameObject.Find("WorldSlider").GetComponent<Slider>().value = GameObject.Find("ARCamera").GetComponent<TrackableList>().worldValue;
   	
        // Aardrijkskunde
		// GameObject.Find("GeographySlider").GetComponent<Slider>().value = GameObject.Find("ARCamera").GetComponent<TrackableList>().geoValue;

    	// Geschiedenis
		// GameObject.Find("HistorySlider").GetComponent<Slider>().value = GameObject.Find("ARCamera").GetComponent<TrackableList>().histValue;
    
		// Natuur
		// GameObject.Find("NatureSlider").GetComponent<Slider>().value = GameObject.Find("ARCamera").GetComponent<TrackableList>().natureValue;

		// Techniek
		// GameObject.Find("TechSlider").GetComponent<Slider>().value = GameObject.Find("ARCamera").GetComponent<TrackableList>().techValue;
    }
}