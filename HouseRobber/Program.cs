using System;

namespace HouseRobber
{
    class Program
    {
        static void Main()
        {

            int[] nums = new int[] { 1,2,3,1}; //4
            int[] nums2 = new int[] { 2, 7, 9, 3, 1 }; // 12
            int[] nums3 = new int[] { 5, 7, 1, 1, 7, 1, 1 }; //15
            int[] nums4 = new int[] { 5, 6, 7, 8, 9, 0, 0, 0, 0, 1, 3, 5 }; //
            Program program = new Program();
            var result = program.Rob(nums4);

            Console.WriteLine(result);
        }







        public int Rob(int[] nums)
        {
            if(nums.Length == 1)
            {
                return nums[0];
            }
            int[] houseValues = new int[nums.Length];
            for(int i = 0; i < houseValues.Length; i++)
            {
                houseValues[i] = -1;
            }
            for(int i = nums.Length - 1; i >= 0; i--)
            {
                if(i == nums.Length - 1)
                {
                    houseValues[i] = nums[i];
                }
                else if(i == nums.Length - 2)
                {
                    houseValues[i] = nums[i];
                }
                else
                {
                    if(i + 2 == houseValues.Length - 1)
                    {
                        houseValues[i] = nums[i] + houseValues[i + 2];
                    }
                    else if(houseValues[i + 2] > houseValues[i + 3])
                    {
                        houseValues[i] = nums[i] + houseValues[i + 2];
                    }
                    else
                    {
                        houseValues[i] = nums[i] + houseValues[i + 3];
                    }
                    
                }
            }

            if(houseValues[0] > houseValues[1])
                return houseValues[0];
            return houseValues[1];
        }
    }
}
