using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName ="Lessons/Lesson1/Rotate Settings")]
public class RotateSettings : ScriptableObject
{
    [SerializeField] public float _speed;

    public float speed { get { return _speed; } }

}
