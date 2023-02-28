using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace LeedCodeCSharp
{
    internal class MedianOfTwoSortedArrays
    {
        public MedianOfTwoSortedArrays()
        {
            int[] x = new int[2]{1,2};
            int[] y = new int[2]{3,4};
            double z =FindMedianSortedArrays(x,y);
            Console.WriteLine(z);
        }

        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            List<int> number1 = nums1.ToList();
            List<int> number2 = nums2.ToList();
            number1.AddRange(number2);

            number1.Sort();

            int listNum = number1.Count / 2;
            if( number1.Count % 2 == 1 ) 
                return number1[listNum];
            else 
            {
                double x = number1[listNum-1];
                double y = number1[listNum];
                return (x+y)/2;
            }
        }
    }
}
