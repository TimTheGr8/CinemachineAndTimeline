using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class PlayTimeline : MonoBehaviour
{
    [SerializeField]
    private PlayableDirector _director;
    [SerializeField]
    private bool _useInput = false;
    [SerializeField]
    private bool _useTrigger = false;

    // Start is called before the first frame update
    void Start()
    {
        if (_director == null)
            Debug.LogError("There is no director to play.");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K) && _useInput)
            _director.Play();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && _useTrigger)
        {
            _director.Play();
        }
    }
}
