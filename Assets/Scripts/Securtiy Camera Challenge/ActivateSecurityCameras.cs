using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateSecurityCameras : MonoBehaviour
{
    private CameraSwitch _camSwitch;

    private void Start()
    {
        _camSwitch = GameObject.Find("V Cams").GetComponent<CameraSwitch>();
        if (_camSwitch == null)
            Debug.LogError("Trigger could not find the Camera Switch Script.");
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            _camSwitch.ToggleCameras(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        { 
            _camSwitch.ToggleCameras(false);
        }
    }
}
