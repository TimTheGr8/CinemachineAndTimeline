using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using TMPro;

public class BodyCameraChallenge : MonoBehaviour
{
    [SerializeField]
    private List<CinemachineVirtualCamera> _vCams = new List<CinemachineVirtualCamera>();
    [SerializeField]
    private List<string> _camNameText = new List<string>();
    [SerializeField]

    private TMP_Text _camName;

    private int _currentCamIndex = 0;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            NextCamera();
        }
    }

    private void NextCamera()
    {
        _currentCamIndex++;
        if (_currentCamIndex >= _vCams.Count)
            _currentCamIndex = 0;
        foreach (CinemachineVirtualCamera cam in _vCams)
        {
            cam.gameObject.SetActive(false);
        }
        _vCams[_currentCamIndex].gameObject.SetActive(true);
        _camName.text = _camNameText[_currentCamIndex];
    }
}
