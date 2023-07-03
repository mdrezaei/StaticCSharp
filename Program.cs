using System;

namespace ConsoleApp5_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassForStaticFields A1 = new ClassForStaticFields();
            A1.Name = "Ali";
            Console.WriteLine(A1.Name);

            //A1.Family = "Malekian";//چون پشت فیلد پابلیک فمیلی ، استاتیک گذاشتیم نمیزاره ما نمونه سازی کنیم و ارور میده
            ClassForStaticFields.Family = "Malekian";//چون استاتیک بود بدون نمونه سازی ازش استفاده کردیم
            Console.WriteLine(ClassForStaticFields.Family);

            string Diffult = ClassForStaticFields.Diffult;
            Console.WriteLine(Diffult);
            ClassForStaticFields.Diffult = "DifDif";
            Console.WriteLine(ClassForStaticFields.Diffult);

            ClassForStaticMethods B = new ClassForStaticMethods();
            int sum = B.Sum(10, 50);
            Console.WriteLine(B.Sum(10, 20));
            Console.WriteLine(sum);

            //int WrongExampel=ClassForStaticMethods.Sum(10, 50);//اشتباه است

            int sum2 = ClassForStaticMethods.Sum2(10, 15);
            Console.WriteLine(sum2);
            Console.WriteLine(ClassForStaticMethods.Sum2(10, 30));
            
            Console.WriteLine($"{AnStaticClass.Exampel}  {AnStaticClass.Exampel3()}");
            AnStaticClass.Exampel2();//چون این متد ویده ما نمیتونیم بهش دستور اجرا بدیم یا درون متغیر بریزیمش. باید دستور اجراش رو توی بدنه خودش بنویسیم

            Console.WriteLine("*****************************");

            StaticConstructor M1 = new StaticConstructor("Name", "Family");//کانستراکتور های پابلیک رو نمونه سازی میکنیم و ایجاد میشوند و بالای همه اون ها کانستراکتور استاتیک هم اجرا میشود
            Console.WriteLine(M1.Name);
            StaticConstructor M2 = new StaticConstructor("Name", "Family");//کانستراکتور استاتیک بدون نمونه سازی از کانستراکتور پابلیک اجرا نمیشود
            StaticConstructor M3 = new StaticConstructor("Name", "Family");//کانستراکتور () خالی ، کد های درون {} شان با نمونه سازی اجرا میشود حتی اگر بعد از انها فیلدز ها را صدا کنیم
            StaticConstructor M4 = new StaticConstructor("Name", "Family");//حتی اگر پرانتز کانستراکتور پر باشد اگر زیر ان ما فیلد را صدا کنیم یا نمونه سازی کنیم ، فیلدز هم اجرا میشود
            StaticConstructor M5 = new StaticConstructor("Name", "Family");//کانستراکتوری که پرانتز پر دارد ولی به فیلدز ها متصل نیست ، درون بلاکش اجرا میشود حتی اگر یکی از اجزای پرانتزش را به کار بگیریم
            ////شما اگر یک کانستراکتور را نمونه سازی کنید ، چه پرانتز خالی چه پر، باز هم اجرا میشود کد های درون بلاکش. چه به فیلدز ها وصل باشد چه وصل نباشد


        }
    }
}
