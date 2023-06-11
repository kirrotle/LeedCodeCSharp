using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeCSharp
{
    internal class RegularExpressionMatching
    {
        public RegularExpressionMatching()
        {
            IsMatch("aa","a*");
        }

        public bool IsMatch(string s, string p)
        {
            List<string> pattern_List = new List<string>();
            for(int pattern_Num = 0 ; pattern_Num < p.Length ; pattern_Num++)
            {
                if(p[pattern_Num+1] == '*')
                {
                    pattern_List.Add(p.Substring(pattern_Num,2));
                    pattern_Num++;
                }
                else
                {
                    pattern_List.Add(p.Substring(pattern_Num, 1));
                }
            }
            
            pattern_List.Select(x=>{Console.WriteLine(x);return x;}).ToList();
            
            
            return false;
        }
    }
}
