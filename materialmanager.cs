using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class materialmanager : MonoBehaviour {

 
    public Material firstMaterial;
    public Material secondMaterial;

    public int caseNumber = 0;

    // Use this for initialization
    void Start () {

            
}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            caseNumber++;
            switch (caseNumber)
            {
                
                case 1:
                    GetComponent<Renderer>().material = firstMaterial;
                    break;

                case 2:
                    GetComponent<Renderer>().material = secondMaterial;
                    break;

               // case 3:
                    //GetComponent<Renderer>().material = secondMaterial;
                  //  break;

                default:
                    caseNumber = 1;
                    GetComponent<Renderer>().material = firstMaterial;
                    break;
            }
        }
        
    }
}
