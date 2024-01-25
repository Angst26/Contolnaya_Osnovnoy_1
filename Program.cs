using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] StringsArray = { "GeekBrains", "HelloWorld", "abc", "hjiufhwei", "ffe", "12f", "fsd", "ffdfew", "124" };
            string[] NewArray = StringsArray.Where(f => f.Length <= 3).ToArray();
            Console.Write(string.Join(",", NewArray));
            Console.ReadLine();
        }



    }
}
