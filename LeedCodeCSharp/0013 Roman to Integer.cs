using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeCSharp
{
    internal class RomantoInteger
    {
        public RomantoInteger()
        {
            Console.WriteLine(RomanToInt("MCMXCIV"));
        }

        public int RomanToInt(string s)
        {
            Dictionary<char,int> roman_Dic = new Dictionary<char, int>()
            {{'I',1},{'V',5},{'X',10},{'L',50},{'C',100},{'D',500},{'M',1000}};

            int output=0;
            for(int pointer = 0 ;pointer < s.Length;pointer++)
            {
                if(pointer+1<s.Length && roman_Dic[s[pointer]]<roman_Dic[s[pointer+1]])
                {
                    output=output+(roman_Dic[s[pointer+1]]-roman_Dic[s[pointer]]);
                    pointer++;
                }
                else
                    output+=roman_Dic[s[pointer]];
            }
            return output;
        }
    }
}
