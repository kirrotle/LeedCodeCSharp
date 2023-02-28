using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeCSharp
{
    internal class ZigzagConversion
    {
        public ZigzagConversion()
        {
            Console.WriteLine(Convert("A", numRows: 1));
        }

        public string Convert(string s, int numRows)
        {
            string answer= "";
            int downWave=numRows*2-2;

            if(numRows==1)
                return s;

            for(int numRow = 0;numRow<numRows;numRow++)
            {
                for(int listNum=numRow;listNum<s.Length;listNum+=(numRows*2-2))
                {
                    if(numRow==0 || numRow == numRows-1)
                        answer +=s[listNum];
                    else
                    {
                        answer+=s[listNum];
                        if( listNum+downWave < s.Length)
                            answer+=s[listNum+downWave];
                    }    
                }
                downWave-=2;
            }
            return answer;
        }
    }
}
