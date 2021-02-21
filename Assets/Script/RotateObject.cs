using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    [SerializeField] private RotateSettings rotateSettings;

    private void Update()
    {
        transform.Rotate(Vector3.up, rotateSettings.speed * Time.deltaTime);
    }

}
