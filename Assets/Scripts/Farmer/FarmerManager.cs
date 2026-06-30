using UnityEngine;

namespace Farmer
{
    public class FarmerManager : MonoBehaviour
    {
        private FarmerController _farmerController;
        private FarmerAnimationController _farmerAnimationController;

        private void Awake()
        {
            _farmerController = GetComponent<FarmerController>();
            _farmerAnimationController = GetComponent<FarmerAnimationController>();
        }

        private void FixedUpdate()
        {
            _farmerAnimationController.FarmerMove(_farmerController.CurrentMoveSpeed);
        }
    }
}
