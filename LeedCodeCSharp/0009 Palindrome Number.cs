using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeCSharp
{
    internal class PalindromeNumber
    {
        public PalindromeNumber()
        {
            Console.WriteLine(IsPalindrome(121));
        }

        public bool IsPalindrome(int x)
        {
            if(x<0)return false;

            string value = x.ToString();
            
            for(int count=0;count<=value.Length/2;count++)
            {
                int lastCount = value.Length - 1 - count;
                if(value[count] != value[lastCount])
                    return false;
            }
            return true;
        }
    }
}
