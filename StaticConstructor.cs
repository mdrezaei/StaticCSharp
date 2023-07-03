using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5_Static
{
    class StaticConstructor
    {
        public string Name = "PublicFields";

        public StaticConstructor(string Name, string Family)
        {
            Console.WriteLine("Public"+Family);
        }

        static StaticConstructor()
        {
            Console.WriteLine("Static");
        }
    }
}
