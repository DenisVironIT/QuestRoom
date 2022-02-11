using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampControl : MonoBehaviour
{
    public Light lamp;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            lamp.enabled = !lamp.enabled;
        }

    }
}
