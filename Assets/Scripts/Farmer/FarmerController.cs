using System;
using UnityEngine;

namespace Farmer
{
    public class FarmerController : MonoBehaviour
    {
        private Rigidbody _farmerRigidbody;
        private Collider _farmerCollider;
        private FarmerAttribute _farmerAttribute;
        
        private Vector3 _farmerDirection;
        private float _currentMoveSpeed;
        
        public float CurrentMoveSpeed => _currentMoveSpeed;
        
        private void Awake()
        {
            _farmerRigidbody = GetComponent<Rigidbody>();
            _farmerCollider = GetComponent<Collider>();
            _farmerAttribute = GetComponent<FarmerAttribute>();
        }

        private void Update()
        {
            _farmerDirection = GetFarmerMovingDirection();
        }

        private void FixedUpdate()
        {
            FarmerMovement(_farmerDirection);
        }
        
        private Vector3 GetFarmerMovingDirection()
        {
            float horizontal = Input.GetAxisRaw("Horizontal");
            float vertical = Input.GetAxisRaw("Vertical");
            Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;
            return direction;
        }

        private void FarmerMovement(Vector3 direction)
        {
            float currentFarmerMovementSpeed = GetCurrentFarmerMovementSpeed();
            _currentMoveSpeed = direction.magnitude * currentFarmerMovementSpeed;
            
            Vector3 targetPosition = transform.position + direction * (currentFarmerMovementSpeed * Time.fixedDeltaTime);
            _farmerRigidbody.MovePosition(targetPosition);
            if (direction != Vector3.zero) transform.forward = direction;
        }
        
        private float GetCurrentFarmerMovementSpeed()
        {
            return _farmerAttribute.FarmerMoveSpeed;
        }
    }
}

