using System;

namespace AP204_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            byte num = 8;
            num += 100; /*num = num + 100*/
            //int intNum = 10;
            string name = "Islam Xalitov";
            //string surname = "Xalitov";
            //name = name + ' ' + surname;
            name = "Tural";
            //Console.WriteLine(name);
            //Console.WriteLine(name);
            //Console.Write(surname);
            //Console.Write(surname);
            //bool result = false;

            //var fullname = "Mustafa Museybov";
            //fullname = 18;
            //dynamic age = 20;
            //age = "Mustafa";
            //age = 20.4;
            //age = true;
            //Console.WriteLine(age);
            //Console.WriteLine(name);
            //string surname = Console.ReadLine();
            //name += surname;
            //Console.WriteLine(name);
            int number = Convert.ToInt32(Console.ReadLine());
            //if (number == 1)
            //{
            //    Console.WriteLine("AZ");
            //}
            //else if (number == 2)
            //{
            //    Console.WriteLine("ENG");
            //}else if(number == 0)
            //{
            //    Console.WriteLine("Operator");
            //}
            //else
            //{
            //    Console.WriteLine("Duzgun reqem daxil edin");
            //}

            switch (number)
            {
                case 1:
                case 2:
                case 0:
                    Console.WriteLine("AZ");
                    break;
                default:
                    Console.WriteLine("Duzgun reqem daxil edin");
                    break;
            }
        }
    }
}
