using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class material_AR : MonoBehaviour
{


    public Material firstMaterial;
    public Material secondMaterial;

    public int caseNumber = 0;
    public Light myLightred;
    public Light myLightblue;
    // Use this for initialization
    void Start()
    {
        myLightred = GameObject.Find("light_red").GetComponent<Light>();
        myLightblue = GameObject.Find("light_blue").GetComponent<Light>();
    }

    // Update is called once per frame
    void OnSelect()
    {


        caseNumber++;
            switch (caseNumber)
            {

                case 1:
                    GetComponent<Renderer>().material = firstMaterial;
                // start video
                Renderer r = GetComponent<Renderer>();
                MovieTexture movie = (MovieTexture)r.material.mainTexture;
                movie.Play();
                movie.loop = true;
                //light control
                //myLightblue.enabled = !myLightblue.enabled;
                //myLightred.enabled = !myLightred.enabled;
                break;


                case 2:
                    GetComponent<Renderer>().material = secondMaterial;
                // start video
                Renderer r2 = GetComponent<Renderer>();
                MovieTexture movie2 = (MovieTexture)r2.material.mainTexture;
                movie2.Play();
                movie2.loop = true;
                myLightblue.enabled = !myLightblue.enabled;
                myLightred.enabled = !myLightred.enabled;
                break;

                // case 3:
                //GetComponent<Renderer>().material = secondMaterial;
                //  break;

                default:
                    caseNumber = 1;
                    GetComponent<Renderer>().material = firstMaterial;
                myLightblue.enabled = !myLightblue.enabled;
                myLightred.enabled = !myLightred.enabled;
                break;
            }
        

    }
}
