﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Topdown Shooter/Camera/Camera Settings")]
public class CameraSettings : ScriptableObject
{
    [SerializeField] private float _rotationLerpSpeed;

    public float RotationLerpSpeed { get { return _rotationLerpSpeed; } }

}
