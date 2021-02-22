using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    [SerializeField] private RotateSettings _rotateSettings;

    private void Update()
    {
        transform.Rotate(Vector3.up, _rotateSettings.speed * Time.deltaTime);
    }

}
    