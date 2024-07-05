using System;
using UnityEngine;

namespace Controller
{
    public class CharacterController : MonoBehaviour
    {
        public Inputs input;
        public Settings setting;

        private Rigidbody2D _rb;
        private CharacterInput _inputClass;

        [Serializable]
        public struct Inputs
        {
            public Vector2 movement;
        }
        
        [Serializable]
        public struct Settings
        {
            public float walkVelocity;
        }
        
        private void Awake()
        {
            _inputClass = new CharacterInput();
        }

        private void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
        }

        private void OnEnable()
        {
            _inputClass.Enable();
        }

        private void Update()
        {
            InputUpdate();
        }

        private void FixedUpdate()
        {
            _rb.AddForce(input.movement * setting.walkVelocity);
        }

        private void InputUpdate()
        {
            input.movement = _inputClass.Player.movement.ReadValue<Vector2>();
        }
    }
}
