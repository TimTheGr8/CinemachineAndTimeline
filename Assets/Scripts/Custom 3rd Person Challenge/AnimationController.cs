using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator _anim;

    void Start()
    {
        _anim = GetComponent<Animator>();
        if (_anim == null)
            Debug.LogError("The player animator could not be found.");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
            _anim.SetTrigger("Death");

        if (Input.GetKey(KeyCode.Mouse1))
            _anim.SetBool("IsAiming", true);
        else if (Input.GetKeyUp(KeyCode.Mouse1))
            _anim.SetBool("IsAiming", false);
    }
}
