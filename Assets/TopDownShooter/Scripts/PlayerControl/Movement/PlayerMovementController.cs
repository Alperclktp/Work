using System.Collections;
using System.Collections.Generic;
using TopDownShooter.PlayerInput;
using UnityEngine;

namespace TopDownShooter.PlayerControls
{
    public class PlayerMovementController : MonoBehaviour
    {
        [SerializeField] private InputData _inputData;
        [SerializeField] private Rigidbody _rigigbody;
        [SerializeField] private PlayerMovementSettings _playerMovementSettings;

        private void Update()
        {
            _rigigbody.MovePosition(_rigigbody.position + (_rigigbody.transform.forward * _inputData.vertical *
                _playerMovementSettings.verticalSpeed));

            _rigigbody.MovePosition(_rigigbody.position + (_rigigbody.transform.right * _inputData.horizontal *
                _playerMovementSettings.horizontalSpeed));
        }
    }
}
