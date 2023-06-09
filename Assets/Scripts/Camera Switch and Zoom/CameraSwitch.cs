using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> _vCams = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            for (int i = 0; i < _vCams.Count - 1; i++)
            {
                _vCams[i].SetActive(false);
            }
        }
    }
}
