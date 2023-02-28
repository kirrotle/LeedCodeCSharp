using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeCSharp
{
    internal class LongestPalindromicSubstring
    {
        public LongestPalindromicSubstring()
        {
            Console.WriteLine(LongestPalindrome("xaabacxcabaaxcabaax"));
        }

        public string LongestPalindrome(string s)
        {
            string answer="";    
            int maxLength=0;

            for(int firstListNum=0;firstListNum<s.Length;firstListNum++)
            {
                for(int secondListNum=firstListNum+1;secondListNum<s.Length;secondListNum++)
                {
                    if(s[firstListNum]==s[secondListNum])
                    {
                        int length = secondListNum-firstListNum+1;
                        if(!Is_Palindrome(s.Substring(firstListNum, length)))continue;
                        answer = maxLength>=length ? answer : s.Substring(firstListNum,length) ;
                        maxLength = maxLength>=length ? maxLength :length;
                    }
                }
            }
            
            if(maxLength==0 && s.Length>0)
                answer=s[0].ToString();

            return answer;
        }

        //判斷回文:開頭結尾比對之後往內比對
        public bool Is_Palindrome(string text)
        {
            for(int i = 0;i<=text.Length/2;i++)
            {
                int j =text.Length-i-1;
                if(text[i]!=text[j])
                    return false;
            }
            return true;
        }
    }
}
