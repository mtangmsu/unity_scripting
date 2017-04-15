using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideobject : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            ToggleVisibility();
        }
    }

    public void ToggleVisibility()
   // function ToggleVisibility()
    {
        Renderer[] renderers = gameObject.GetComponentsInChildren<Renderer>();
        foreach (Renderer r in renderers)
        {
            r.enabled = !r.enabled;
            // r.enabled = !isHidden;
        }
    }
}

