namespace LeedCodeCSharp
{
    public class Test
    {
        public static void Main(string[] args)
        {
            RegularExpressionMatching x = new RegularExpressionMatching();
            Console.WriteLine(x.IsMatch("ab" , ".*c")); 
        }
    } 
}
