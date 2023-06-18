using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> _vCams = new List<GameObject>();

    private int _currentCamIndex = 0;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
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
}
