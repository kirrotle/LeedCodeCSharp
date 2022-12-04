using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeCSharp
{
    internal class TwoSum
    {
        public TwoSum()
        {
            var value = Two_Sum_1(new int[] { 3, 2, 4 }, 6);
            value.ToList().ForEach(num => Console.WriteLine(num));
        }

        public int[] Two_Sum_1(int[] nums, int target)
        {
            for ( int i = 0; i < nums.Count(); i++ )
            {
                for ( int j = 0; j < nums.Count(); j++ )
                {
                    if ( i == j )
                        continue;
                    if ( nums[i] + nums[j] == target )
                        return new int[2] { i, j };
                }
            }
            return new int[2] { 0, 1 };
        }
        
        public int[] Two_Sum_2(int[] nums, int target)
        {
            foreach ( int value in nums)
            {
                var remain = target - value;
                if ( nums.Contains(remain) )
                {
                    int answer1 = nums.ToList().FindIndex(x => x==remain);
                    int answer2 = nums.ToList().FindLastIndex(x => x==value);
                    if ( answer1 == answer2 )
                        continue;
                    return new int[] { answer1, answer2};
                }
            }

            return new int[] {0,1};
        }

    }
}
