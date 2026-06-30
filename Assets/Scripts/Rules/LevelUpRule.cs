using Farmer;
using UnityEngine;

namespace Rules
{
    public class LevelUpRule : MonoBehaviour
    {
        private static readonly int[] LevelUpExpValCheckArr = {
            30, 70, 100, 130, 180, 200, 240, 260, 300
        };

        public void LevelUpRuleFunction()
        {
            int currentFarmerLevel = GetComponent<FarmerAttribute>().GetFarmerLevel();
            int currentFarmerCheckExpVal = LevelUpExpValCheckArr[currentFarmerLevel];
            int currentFarmerExpVal = GetComponent<FarmerAttribute>().GetFarmerExpVal();
            if (CheckCanLevelUp(currentFarmerExpVal, currentFarmerCheckExpVal))
            {
                GetComponent<FarmerAttribute>().AddFarmerLevel();
            }
        }

        private bool CheckCanLevelUp(int currentFarmerExpVal, int currentFarmerCheckExpVal)
        {
            return currentFarmerExpVal >= currentFarmerCheckExpVal;
        }
    }
}