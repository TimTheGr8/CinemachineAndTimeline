using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Custom3rdPersonCamera : MonoBehaviour
{
    [SerializeField]
    private CinemachineVirtualCamera _3rdPersonCam, _orbitalCam;

    private bool _orbitalCamActive = false;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Mouse1) && !_orbitalCamActive)
        {
            _3rdPersonCam.Priority = 10;
            _orbitalCam.Priority = 15;
            _orbitalCamActive = true;
        }
        if(Input.GetKeyUp(KeyCode.Mouse1) && _orbitalCamActive)
        {
            _orbitalCam.Priority = 10;
            _3rdPersonCam.Priority = 15;
            _orbitalCamActive = false;
        }
        
    }
}
