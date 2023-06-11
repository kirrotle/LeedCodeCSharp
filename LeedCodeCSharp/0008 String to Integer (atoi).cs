using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeCSharp
{
    internal class StringtoInteger
    {
        public StringtoInteger()
        {
            Console.WriteLine(MyAtoi("3-"));
        }

        public int MyAtoi(string s)
        {
            if(string.IsNullOrEmpty(s))return 0;    

            string output ="";

            foreach (var text in s)
            {
                if(text >= 48 && text <= 57)
                {
                    output+=text;
                }
                else if(text==43||text==45 )
                {
                    if(output.Length>=1)
                        break;
                    else
                        output+=text;
                }
                else if(text == ' ' && output.Length==0)
                {
                    continue;
                }
                else
                {
                    break;
                }
            }


            try
            {
                return Convert.ToInt32(output);
            }
            catch ( Exception )
            {
                if(output=="" || output == "-" || output =="+")
                    return 0;
                else if(output.Contains('+') && output.Contains('-'))
                    return 0;
                else if(output.Contains('+') && output[0]!='+')
                    return 0;
                else if ( output.Contains('-')&&output[0]!='-' )
                    return 0;

                else if(output[0]=='-')
                    return (int)Math.Pow(-2, 31);
                else if ( output[0]=='+' || ( output[0]>=48 && output[0]<=57 ) )
                    return (int)Math.Pow(2, 31)-1;
                else 
                    return 0;
            }
            
        }

    }
}
