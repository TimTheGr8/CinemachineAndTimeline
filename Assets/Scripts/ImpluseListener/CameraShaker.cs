using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraShaker : MonoBehaviour
{
    [SerializeField]
    private CinemachineImpulseSource _source;


    // Start is called before the first frame update
    void Start()
    {
        _source = GetComponent<CinemachineImpulseSource>();
        if (_source == null)
            Debug.LogError("Impulse could not find the Source");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Shake();
        }
    }


    public void Shake()
    {
        _source.GenerateImpulse();
    }
}
