using System;
using UnityEngine;

namespace Farmer
{
    public class FarmerAnimationController : MonoBehaviour
    {
        private Animator _farmerAnimator;
        
        private int _farmerMoveSpeedHash;

        private void Awake()
        {
            _farmerAnimator = GetComponent<Animator>();
            _farmerMoveSpeedHash = Animator.StringToHash("farmerMoveSpeed");
        }

        public void FarmerMove(float farmerMoveSpeed)
        {
            _farmerAnimator.SetFloat(_farmerMoveSpeedHash, farmerMoveSpeed);
        }
        
    }
}