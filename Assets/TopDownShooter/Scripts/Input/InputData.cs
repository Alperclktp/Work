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

        [Header("Axix Base Control")]
        [SerializeField] private bool _axisActive;
        [SerializeField] private string axixNameHorizontal;
        [SerializeField] private string axisNameVertical;

        [Header("Key Base Control")]
        [SerializeField] private bool _keyBaseHorizontalActive;
        [SerializeField] private KeyCode positiveHorizontalKeyCode;
        [SerializeField] private KeyCode negaviteHorizontalKeyCode;
        [SerializeField] private bool _keyBaseVerticalActive;
        [SerializeField] private KeyCode positiveVerticalKeyCode;
        [SerializeField] private KeyCode negaviteVerticalKeyCode;
        [SerializeField] private float _increaseAmonut = 0.0015f;

        public void ProcessInput()
        {
            if (_axisActive)
            {
                horizontal = Input.GetAxis(axixNameHorizontal);
                vertical = Input.GetAxis(axisNameVertical);
            }
            else
            {
                if (_keyBaseHorizontalActive)
                {          
                    bool positiveActive = Input.GetKey(positiveHorizontalKeyCode);
                    bool negativeActive = Input.GetKey(negaviteVerticalKeyCode);

                    if (_keyBaseHorizontalActive)
                    {
                        KeyBaseAxisControl(ref horizontal, positiveHorizontalKeyCode, negaviteHorizontalKeyCode);
                    }

                    if (_keyBaseVerticalActive)
                    {
                        KeyBaseAxisControl(ref vertical, positiveVerticalKeyCode, negaviteVerticalKeyCode);
                    }
                }
            }
        }

        private void KeyBaseAxisControl(ref float value, KeyCode positive, KeyCode negavite)
        {
            bool positiveActive = Input.GetKey(positive);
            bool negativeActive = Input.GetKey(negavite);

            if (positiveActive)
            {
                value += _increaseAmonut;
            }
            else if (negativeActive)
            {
                value -= _increaseAmonut;
            }
            else
            {
                value = 0;
            }
            value = Mathf.Clamp(value, -1, 1);
        }
    }
}
