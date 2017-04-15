using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideobject_2 : MonoBehaviour
{


    // Update is called once per frame
    void OnSelect()
    {
            ToggleVisibility();
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

