using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.PlayerMovement
{
    [CreateAssetMenu(menuName = "Topdown Shooter/Player/Movement Settings")]
    public class PlayerMovementSettings : ScriptableObject
    {
        public float horizontalSpeed;
        public float verticalSpeed;
    }
}
