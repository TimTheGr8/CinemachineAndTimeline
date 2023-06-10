using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger : MonoBehaviour
{
    [SerializeField]
    private int _cameraIndex = -1;

    private CameraController _cameraController;

    // Start is called before the first frame update
    void Start()
    {
        _cameraController = GameObject.Find("Virtual Cameras").GetComponent<CameraController>();
        if (_cameraController == null)
            Debug.LogError("The trigger did not find the Virtual Cameras.");
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            _cameraController.SwitchCameras(_cameraIndex);
        }
    }
}
