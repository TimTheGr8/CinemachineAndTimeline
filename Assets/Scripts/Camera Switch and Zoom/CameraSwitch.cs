using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> _vCams = new List<GameObject>();

    private int _currentCamIndex = 0;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            _currentCamIndex++;
            if (_currentCamIndex > _vCams.Count - 1)
                _currentCamIndex = 0;

            foreach(var cam in _vCams)
            {
                cam.SetActive(false);
            }
            _vCams[_currentCamIndex].SetActive(true);
        }
    }

    public void ToggleCameras(bool areCamerasOn)
    {
        foreach (var cam  in _vCams)
        {
            cam.SetActive(areCamerasOn);
        }
    }
}
