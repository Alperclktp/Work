using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private CameraSettings _cameraSettings;

    [SerializeField] private Transform _targetTransform;
    [SerializeField] private Transform _cameraTransform;

    private void Update()
    {
        CameraRotationFollow();
    }

    private void CameraRotationFollow()
    {
        _cameraTransform.rotation = Quaternion.Lerp(_cameraTransform.rotation,
           Quaternion.LookRotation(_cameraTransform.forward),
           Time.deltaTime * _cameraSettings.RotationLerpSpeed);
    }
}
