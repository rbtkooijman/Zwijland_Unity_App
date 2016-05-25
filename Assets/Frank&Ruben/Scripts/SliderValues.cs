using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SliderValues : MonoBehaviour {

    // Create booleans to remember if the complete banners is visible
    public bool geoCompleteVisible, histCompleteVisible, natCompleteVisible, techCompleteVisible, worldCompleteVisible;

    // Create booleans to remember if the complete banners has been closed
    public bool geoCompleteClosed, histCompleteClosed, natCompleteClosed, techCompleteClosed, worldCompleteClosed;

    // Create references to the animator components of the 'completed' banners
    public Animator animGeoBanner, animHistBanner, animNatBanner, animTechBanner, animWorldBanner;

    // Create references to the audio components of the 'completed' banners
    public AudioSource audioCompleteBanner, audioWorldCompleteBanner;

	// Update is called once per frame
    void Update () {

        // Store the object references to the animator components of the 'completed' banners
        animGeoBanner = GameObject.Find("GeoComplete").GetComponent<Animator>();
        animHistBanner = GameObject.Find("HistComplete").GetComponent<Animator>();
        animNatBanner = GameObject.Find("NatComplete").GetComponent<Animator>();
        animTechBanner = GameObject.Find("TechComplete").GetComponent<Animator>();
        animWorldBanner = GameObject.Find("WorldComplete").GetComponent<Animator>();

        // Store the object references to the audio components of the 'completed' banners
        audioCompleteBanner = GameObject.Find("GeoComplete").GetComponent<AudioSource>();
        audioWorldCompleteBanner = GameObject.Find("WorldComplete").GetComponent<AudioSource>();

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
        
        // Place the world value in the world slider object, which moves towards the new value in steps of 1f
        GameObject.Find("WorldSlider").GetComponent<Slider>().value = Mathf.MoveTowards (GameObject.Find("WorldSlider").GetComponent<Slider>().value, GameObject.Find("ARCamera").GetComponent<TrackableList>().worldValue, 1f);

            // Place the rounded world value in the world percentage text label
            GameObject.Find("WorldPercentLabel").GetComponent<Text>().text = worldRounded + "%";
   	
        // Place the geography value in the respective slider object, which moves towards the new value in steps of 1f
		GameObject.Find("GeoSlider").GetComponent<Slider>().value = Mathf.MoveTowards (GameObject.Find("GeoSlider").GetComponent<Slider>().value, GameObject.Find("ARCamera").GetComponent<TrackableList>().geoValue, 3f);

            // Place the rounded geography value in the geography percentage text label
            GameObject.Find("GeoPercentLabel").GetComponent<Text>().text = geoRounded + "%";        

        // Place the history value in the respective slider object, which moves towards the new value in steps of 1f
		GameObject.Find("HistSlider").GetComponent<Slider>().value = Mathf.MoveTowards (GameObject.Find("HistSlider").GetComponent<Slider>().value, GameObject.Find("ARCamera").GetComponent<TrackableList>().histValue, 3f);

            // Place the rounded history value in the history percentage text label
            GameObject.Find("HistPercentLabel").GetComponent<Text>().text = histRounded + "%";          
    
        // Place the nature value in the respective slider object, which moves towards the new value in steps of 1f
		GameObject.Find("NatSlider").GetComponent<Slider>().value = Mathf.MoveTowards (GameObject.Find("NatSlider").GetComponent<Slider>().value, GameObject.Find("ARCamera").GetComponent<TrackableList>().natValue, 3f);

            // Place the rounded nature value in the nature percentage text label
            GameObject.Find("NatPercentLabel").GetComponent<Text>().text = natRounded + "%";  

        // Place the technology value in the respective slider object, which moves towards the new value in steps of 1f
		GameObject.Find("TechSlider").GetComponent<Slider>().value = Mathf.MoveTowards (GameObject.Find("TechSlider").GetComponent<Slider>().value, GameObject.Find("ARCamera").GetComponent<TrackableList>().techValue, 3f);

            // Place the rounded technology value in the technology percentage text label
            GameObject.Find("TechPercentLabel").GetComponent<Text>().text = techRounded + "%";

// geoCompleteClosed == false && histCompleteClosed == false && natCompleteClosed == false && techCompleteClosed == false && worldCompleteClosed == false

        // Check if the geography slider is at a value of 100%, it's not already open or closed and if no other banners are open
        if (GameObject.Find("GeoSlider").GetComponent<Slider>().value == 100 
            && geoCompleteVisible == false 
            && geoCompleteClosed == false
            && histCompleteVisible == false
            && natCompleteVisible == false
            && techCompleteVisible == false) {
            
            // Play banner open animation
            animGeoBanner.Play("ShowCompleteBanner");

            // Play banner open sound effect
            audioCompleteBanner.Play();

            // Set Geography complete banner state to 'shown'
            geoCompleteVisible = true;

            // Debug.Log ("Geography complete!");
        }

        // Check if the history slider is at a value of 100%, it's not already open or closed and if no other banners are open
        if (GameObject.Find("HistSlider").GetComponent<Slider>().value == 100 
            && histCompleteVisible == false
            && histCompleteClosed == false
            && geoCompleteVisible == false
            && natCompleteVisible == false
            && techCompleteVisible == false) {

            // Play banner open animation
            animHistBanner.Play("ShowCompleteBanner");

            // Play banner open sound effect
            audioCompleteBanner.Play();            

            // Set History complete banner state to 'shown'
            histCompleteVisible = true;

            // Debug.Log ("History complete!");
        }

        // Check if the nature slider is at a value of 100%, it's not already open or closed and if no other banners are open
        if (GameObject.Find("NatSlider").GetComponent<Slider>().value == 100 
            && natCompleteVisible == false
            && natCompleteClosed == false
            && geoCompleteVisible == false
            && histCompleteVisible == false
            && techCompleteVisible == false) {

            // Play banner open animation
            animNatBanner.Play("ShowCompleteBanner");

            // Play banner open sound effect
            audioCompleteBanner.Play();            

            // Set Nature complete banner state to 'shown'
            natCompleteVisible = true;

            // Debug.Log ("Nature complete!");
        }

        // Check if the technology slider is at a value of 100%, it's not already open or closed and if no other banners are open
        if (GameObject.Find("TechSlider").GetComponent<Slider>().value == 100 
            && techCompleteVisible == false
            && techCompleteClosed == false
            && geoCompleteVisible == false
            && histCompleteVisible == false
            && natCompleteVisible == false) {

            // Play banner open animation
            animTechBanner.Play("ShowCompleteBanner");

            // Play banner open sound effect
            audioCompleteBanner.Play();            

            // Set Technology complete banner state to 'shown'
            techCompleteVisible = true;

            // Debug.Log ("Technology complete!");
        }

        // Check if the world slider is at a value of 100%, it's not open or already closed and
        // if all other banners have already been closed
        if (GameObject.Find("WorldSlider").GetComponent<Slider>().value == 100 
            && worldCompleteVisible == false
            && worldCompleteClosed == false
            && geoCompleteClosed == true
            && histCompleteClosed == true
            && natCompleteClosed == true
            && techCompleteClosed == true) {

            // Play banner open animation
            animWorldBanner.Play("ShowWorldCompleteBanner");
            
            // Play banner open sound effect
            audioWorldCompleteBanner.Play();            

            // Set World complete banner state to 'shown'
            worldCompleteVisible = true;

            // Debug.Log ("World complete!");
        }        
    }
}