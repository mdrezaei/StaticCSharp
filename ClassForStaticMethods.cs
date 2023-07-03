using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5_Static
{
    class ClassForStaticMethods
    {
        public int Sum(int a,int b)//حتما باید نمونه سازی بشود بدون نمونه سازی نمیاید
        {
            return a + b;
        }

        public static int Sum2(int a,int b)
        {
            return a + b;
        }
    }
}
