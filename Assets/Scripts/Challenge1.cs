using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Challenge1 : MonoBehaviour
{
    [SerializeField]
    private GameObject _cube, _sphere;

    [SerializeField]
    private float[] _fov = {60, 40, 20};

    private bool _lookingAtCube = true;
    private CinemachineVirtualCamera _cam;
    private int _currentFOV;

    // Start is called before the first frame update
    void Start()
    {
        _cam = GetComponent<CinemachineVirtualCamera>();
        if (_cam == null)
            Debug.LogError("There is no Virtual Camera.");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            _cam.LookAt = _lookingAtCube ? _sphere.transform : _cube.transform;

            _lookingAtCube = !_lookingAtCube;
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            _cam.m_Lens.FieldOfView = _fov[ChangeFOV()];
        }
    }

    private int ChangeFOV()
    {
        _currentFOV++;
        if (_currentFOV >= _fov.Length)
            _currentFOV = 0;
        return _currentFOV;
    }
}
