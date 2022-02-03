using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightDayControl : MonoBehaviour
{
    public GameObject lightSunControl;
    public int DayTime;
    private void FixedUpdate()
    {
        lightSunControl.transform.Rotate(Vector3.right * DayTime * Time.deltaTime);
    }
}
