using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Lessons/Lesson1/Control Rigigbody Settings")]
public class RigigbodySettings : ScriptableObject
{
    [SerializeField] private Vector3 _jumpForce;

    public Vector3 jumpForce { get { return _jumpForce; } }

}
