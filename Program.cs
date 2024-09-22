using System.Runtime.CompilerServices;

namespace LeetCode__169_Majority_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] nums = { 2, 2, 1, 1, 1, 2, 2 };
            Console.WriteLine(MajorityElement(nums));
        }

        //This method uses the Moore Voting algorithm to find the number that appears the most.
        public static int MajorityElement(int[] nums)
        {
            int majorityNumber = 0;
            int count = 0;

            foreach (int num in nums)
            {
                if (count == 0)
                {
                    majorityNumber = num;
                    count++;
                }
                else if (count > 0 && num == majorityNumber)
                {
                    count++;
                }
                else if (count > 0 && num != majorityNumber)
                {
                    count--;
                }
            }

            return majorityNumber;
        }
    }
}
