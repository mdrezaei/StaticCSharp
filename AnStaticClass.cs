using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5_Static
{
    static class AnStaticClass
        //در کلاس استاتیک تمام زیر مجموعه ها وتوابع این کلاس باید و باید استاتیک باشن از فیلدز گرفته تا متد
    {
        //چرا اینجا استرینگ تعریف کنیم فیلد میشه وریبل نمیشه
        //چون در متد هست که وریبل داریم متغیر داریم نه در کلاس

        public static string Exampel = "STATIC";

        //string Exampel1 = "Static";// این استرینگ چون استاتیک نیست در این کلاس ارور میده. این یک استرینگ پرایوته که استاتیک نیست . دقیقا برعکس بالا

        public static void Exampel2()
        {
            string NonSTATIC = "ABCD";//در متد لازم به استاتیک نیست

            Console.WriteLine("Static");
        }
        public static string Exampel3()
        {
            return "Static";
        }



    }
}
