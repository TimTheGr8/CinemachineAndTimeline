using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private List<CinemachineVirtualCamera> _vCams = new List<CinemachineVirtualCamera>();

    public void SwitchCameras(int camIndex)
    {
        foreach (CinemachineVirtualCamera camera in _vCams)
        {
            camera.Priority = 10;
        }
        _vCams[camIndex].Priority = 15;
    }
}
