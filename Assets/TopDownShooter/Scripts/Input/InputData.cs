using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TopDownShooter.PlayerInput
{
    [CreateAssetMenu(menuName = "Topdown Shooter/Input/Input Data")]
    public class InputData : ScriptableObject
    {
        public float horizontal;
        public float vertical;
    }
}
