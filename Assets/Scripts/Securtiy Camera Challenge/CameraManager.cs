using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] List<CinemachineVirtualCamera> _vCams = new List<CinemachineVirtualCamera>();

   
    private bool _canSwitchCams = false;
    [SerializeField]
    private int _currentCamIndex = 1;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C) && _canSwitchCams)
        {
            _currentCamIndex++;
            if (_currentCamIndex > _vCams.Count - 1)
                _currentCamIndex = 1;

            foreach (var cam in _vCams)
            {
                cam.Priority = 10;
            }
            _vCams[_currentCamIndex].Priority = 15;
        }
    }

    public void ToggleCameras(bool areCamerasOn)
    {
        _canSwitchCams = areCamerasOn;
        foreach (var cam in _vCams)
        {
            cam.Priority = 10;
        }
        if(areCamerasOn)
            _vCams[1].Priority = 15;
        if (!areCamerasOn)
            _vCams[0].Priority = 10;
    }
}
