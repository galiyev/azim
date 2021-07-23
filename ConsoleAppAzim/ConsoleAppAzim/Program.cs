
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppAzim
{
    class Program
    {
        static void Main(string[] args)
        {
            //FindPerimetr(56);
            Calc();
            SummAndShow(34,54);
            Thread.Sleep(7000);
        }


        static void ReadStringFromKeyboard()
        {
            string vvod = Console.ReadLine();
            decimal decChislo = Convert.ToDecimal(vvod);     
         //   int chislo = Convert.ToDecimal(vvod);
        }


        static void Calc()
        {
            string AStr2 = Console.ReadLine();
            string BStr = Console.ReadLine();
            int a = Convert.ToInt32(AStr2);
            int b = Convert.ToInt32(BStr);

            int c = a + b;

            Console.WriteLine($"{a} + {b} = {c}");

        }

        static void SummAndShow(int a, int b)// метод
        {
            int c = a + b;
            Console.WriteLine($"Я сложил числа {a} и {b} и получилось {c} {c}");
            Thread.Sleep(3000);
        }

        static void FindPerimetr(int a)
        {
            int P;
            P = 4 * a;
            Console.WriteLine($"Ура! Я нашел периметр квадрата со стороной {a} и он равен {P}");
            Thread.Sleep(4000);
        }

        static void Zadacja2(int a)
        {
            int P;
            P = 4 * a;
            Console.WriteLine($"Ура! Я нашел периметр квадрата со стороной {a} и он равен {P}");
            Thread.Sleep(4000);
        }
    }
}

namespace CarParking
{
    class Ohrana
    {

    }

    class Car
    {

    }
}

