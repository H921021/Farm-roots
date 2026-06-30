using UnityEngine;

namespace Farmer
{
    public class FarmerAttribute : MonoBehaviour
    {
        [Header("Farmer Move Attribute")]
        [SerializeField] private float farmerMoveSpeed;
        
        [Header("Farmer Coin Attribute")]
        [SerializeField] private int farmerCoinNumber;
        
        [Header("Farmer ExpVal Attribute")]
        [SerializeField] private int farmerExpVal;
        
        [Header("Farmer Level Attribute")]
        [SerializeField] private int farmerLevel;
        
        public float FarmerMoveSpeed => farmerMoveSpeed;
        public int FarmerCoinNumber => farmerCoinNumber;
        public int FarmerExpVal => farmerExpVal;
        public int FarmerLevel => farmerLevel;

        public float GetfarmerMoveSpeed()
        {
            return FarmerMoveSpeed;
        }

        public int GetFarmerCoinNumber()
        {
            return FarmerCoinNumber;
        }

        public int GetFarmerExpVal()
        {
            return FarmerExpVal;
        }

        public int GetFarmerLevel()
        {
            return FarmerLevel;
        }

        public void AddFarmerLevel()
        {
            farmerLevel++;
        }
    }
}