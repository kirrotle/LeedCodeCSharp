using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeCSharp
{
    internal class ReverseInteger
    {
        public  ReverseInteger()
        {
            Console.WriteLine(Reverse(1534236469));
        }

        public int Reverse(int x)
        {
            string answer ="";
            if(x<0)
            {
                answer+="-";
                x*=-1;
            }

            string temp = x.ToString();
            for(int arrayNum=temp.Length-1;arrayNum>=0;arrayNum--)
            {
                answer+=temp[arrayNum];
            }
            
            try
            {
                return Convert.ToInt32(answer);
            }
            catch ( Exception )
            {
                return 0;
            }

        }

    }
}
