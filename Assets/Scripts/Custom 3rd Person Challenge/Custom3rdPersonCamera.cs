using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Custom3rdPersonCamera : MonoBehaviour
{
    [SerializeField]
    private CinemachineVirtualCamera _3rdPersonCam;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Mouse1))
        {
            _3rdPersonCam.gameObject.SetActive(false);
        }
        if(Input.GetKeyUp(KeyCode.Mouse1))
        {
            _3rdPersonCam.gameObject.SetActive(true);
        }
        
    }
}
