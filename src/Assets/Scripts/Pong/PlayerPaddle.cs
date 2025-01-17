using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

namespace ClassicGames.Pong
{
    public class PlayerPaddle : MonoBehaviour
    {
        private PlayerControls _playerControls;
        private Rigidbody2D _rigidbody;
        public float _speed = 2.0f;

        private void Awake()
        {
            _playerControls = new PlayerControls();
            _rigidbody = GetComponent<Rigidbody2D>();
        }

        private void OnEnable()
        {
            if (_playerControls != null)
            {
                _playerControls.Enable();
                _playerControls.PongGameplay.Move.canceled += OnMoveCancelled;
                _playerControls.PongGameplay.Move.performed += OnMove;
            }
        }

        private void OnDisable()
        {
            if (_playerControls != null)
            {
                _playerControls?.Disable();
                _playerControls.PongGameplay.Move.canceled -= OnMoveCancelled;
                _playerControls.PongGameplay.Move.performed -= OnMove;
            }
        }

        private void OnMove(InputAction.CallbackContext context)
        {
            var moveDirection = context.ReadValue<Vector2>();
            if (_rigidbody != null)
            {
                _rigidbody.velocity = moveDirection * _speed;
            }
        }

        private void OnMoveCancelled(InputAction.CallbackContext context)
        {
            if (_rigidbody != null)
            {
                _rigidbody.velocity = Vector2.zero;
            }
        }

    }
}

