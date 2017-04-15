using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class togglelight : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.C))
        {
            //GetComponent<Light>().GetComponent<Light>().enabled = false;
//Light myLight = GetComponent<Light>().GetComponent<Light>();
            Light myLight = GetComponent<Light>();
            myLight.enabled = !myLight.enabled;
        }

        }
}
