using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TopDownShooter.PlayerInput
{
    public class InputManager : MonoBehaviour
    {
        [SerializeField] private InputData _inputData;
        [SerializeField] private InputData _rotationInputData;

        private Vector3 _lastMouseInput;

        private void Update()
        {
            _inputData.horizontal = Input.GetAxis("Horizontal");
            _inputData.vertical = Input.GetAxis("Vertical");

            _rotationInputData.horizontal = (Input.mousePosition.x - _lastMouseInput.x);

            _lastMouseInput = Input.mousePosition;

                
        }    
    }
}


 