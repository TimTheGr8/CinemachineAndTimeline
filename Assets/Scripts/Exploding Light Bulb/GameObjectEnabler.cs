using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class GameObjectEnabler : MonoBehaviour
{
    [SerializeField]
    private PlayableDirector _object;
    [SerializeField]
    private Material _mat;
    [SerializeField]
    private MeshRenderer _light;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        { 
            _object.Play();
            StartCoroutine(WaitForSeconds(0.5f));
        }  
    }

    IEnumerator WaitForSeconds(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        _light.material = _mat;
    }
}
