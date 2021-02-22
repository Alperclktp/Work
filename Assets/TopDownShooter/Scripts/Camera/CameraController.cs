﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TopDownShooter.Shooting;


namespace TopDownShooter.Camera
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private CameraSettings _cameraSettings;
        [SerializeField] private ShootingManager _shootingManager;

        [SerializeField] private Transform _targetTransform;
        [SerializeField] private Transform _cameraTransform;

        private void Update()
        {
            CameraRotationFollow();
            CameraMovementFollow();

            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Debug.Log("try shoot");
                _shootingManager.Shoot(_cameraTransform.position, _cameraTransform.forward);
            }
        }

        private void CameraRotationFollow()
        {
            _cameraTransform.rotation = Quaternion.Lerp(_cameraTransform.rotation,
               Quaternion.LookRotation(_cameraTransform.forward),
               Time.deltaTime * _cameraSettings.RotationLerpSpeed);
        }

        private void CameraMovementFollow()
        {
            _cameraTransform.position = Vector3.Lerp(_cameraTransform.position,
                _targetTransform.position + _cameraSettings.PositionOffset, Time.deltaTime *
                _cameraSettings.PositionLerp);
        }
    }

}