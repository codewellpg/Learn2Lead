using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LCEClassLibrary1;

namespace LCE1
{
    class Program
    {
        static void Main(string[] args)
        {
            LCE lce = new LCE();
            
            Console.WriteLine(lce.PrintNumbers(new Range(), null));

            Console.ReadLine();

            Console.WriteLine(lce.PrintNumbers(new Range(), new Dictionary<int, string> { }));

            Console.ReadLine();

            Console.WriteLine(lce.PrintNumbers(new Range(1,10)));

            Console.ReadLine();

            Console.WriteLine(lce.PrintNumbers(new Range(1, 10), new Dictionary<int, string> { {1,"ONE"}}));

            Console.ReadLine();

            Console.WriteLine(lce.PrintNumbers(replaceWith: new Dictionary<int, string> { {10,"TEN"}}));

            Console.ReadLine();
        }
    }   

}
