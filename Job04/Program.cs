// Paul Stefanik, September 9th, 2014, Job #04
// The purpose of this program is to display an output based on the numeric and charactered variables given

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            //Declare Variables
            String name;
            String subject;
            int mark;

            //Assign Values
            name = "Mickey Mouse";
            subject = "Math";
            mark = 85;

            //Output Information*
            Console.WriteLine("Personal information for: " + name);
            Console.WriteLine();
            Console.WriteLine("Favorite subject          " + subject);
            Console.WriteLine("Hopeful Mark in Course:   " + mark);
            Console.WriteLine();
        }
    }
}
