using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClassLibrary1;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> modulusDict = new Dictionary<int, string>();
            modulusDict.Add(3, "fizz");
            modulusDict.Add(5, "buzz");
            modulusDict.Add(10, "snap");

            //ClassLibrary1.Class1.AnalyzeNumbers(50, 100, modulusDict);

            ClassLibrary1.Class1.writeOutput(Class1.AnalyzeNumbers(1, 100, modulusDict));

            //ClassLibrary1.Class1.AnalyzeNumbers(50,100,3,5,"fizz","buzz");
            
        }
    }
}
