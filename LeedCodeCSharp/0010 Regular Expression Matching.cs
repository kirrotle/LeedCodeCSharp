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
        }

        public bool IsMatch(string s, string p)
        {
            int sIndex = s.Length - 1;
            int pIndex = p.Length - 1;
            for(int i = 0 ;i<(sIndex<=pIndex ? sIndex : pIndex) ;i++ )
            {
                if( s[sIndex] == p[pIndex] )
                {
                    sIndex--;
                    pIndex--;
                    break;
                }
                else
                {
                    if( p[pIndex] != '*' || p[pIndex] != '.' )
                    {
                        
                    }
                }
            }

            for( int i = 0 ; i < ( sIndex <= pIndex ? sIndex : pIndex ) 
            ; i++ )
            {
                if( pIndex - 1 < i )
                    return false;
                if( s[i] != p[i] )
                {
                    if( p[i] == 46 )//.
                    {
                        continue;
                    }
                    else if( p[i] == 42 )//*
                    {
                        CheckMuti(ref i , s , p);
                    }
                    //*可以是0~無限多個
                    else if( p[i + 1] == 42 )
                    {
                        i = i + 1;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return true;

        }

        public void CheckMuti(ref int index,string s, string p)
        {
            if( p[index-1] == 46 )//.
            {
                index = s.Length - 1;
                return;
            }

            for( int i = index ; i<s.Length ;i++ )
            {
                if( s[i] != p[index - 1] )
                {
                    index = i-1;
                } 
            }
        }
    }
}
