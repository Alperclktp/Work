using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlRigigBody : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigigbody;
    [SerializeField] private RigigbodySettings _settings;

    private void Update()
    {
       if (Input.GetKeyDown(KeyCode.Space))
       {
            _rigigbody.AddForce(_settings.jumpForce, ForceMode.Impulse);
       }
    }
}
