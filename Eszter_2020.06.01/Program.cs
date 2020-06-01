using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eszter_2020._06._01
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.feladat:Sorsolj ki egy egész számot a [7;24] intervallumból. Írd ki a szám osztóit!
            Random veletlen = new Random();
            int szam = veletlen.Next(7,25);
            Console.Write($"A {szam} osztói: ");
            //Ki kell írni az osztóit.
            for (int i = 1; i<=szam;i++)
            {
                if (szam % i == 0)
                {
                    Console.Write($"{i}, ");
                }
            }

            //Generáljunk egy véletlen egész számot a [90;100] intervallumból.
            int szam1 = veletlen.Next(90,101);
            //5.1.Számoljuk meg hány darab páros és páratlan osztólya van a generált számnak
            int paros = 0;
            int paratlan = 0;
            for (int i = 1; i <= szam1; i++)
            {
                if (szam1 % i == 0)
                {
                    if (i % 2 == 0)
                    {
                        paros++;
                    }
                    else
                    {
                        paratlan++;
                    }

                }
            }
            Console.WriteLine($"\nA {szam1} számnak {paros}db páros és {paratlan}db páratlan osztólya van.");

            //6.feladat:Kérj be 2 egész számot a felhasználótól a [-100;100] intervallumból, 
            //és írd ki a közöttük lévő páros számokat!
            Console.Write("Kérem adjon meg egy egész számot a [-100;100] intervallumból: ");
            int szam2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérem adjon meg egy másik egész számot a [-100;100] intervallumból: ");
            int szam3 = int.Parse(Console.ReadLine());
            if (szam2 > szam3)
            {
                Console.Write($"{szam3};{szam2} intervallumban a páros számok: ");
                int db = 0;
                for (int i = szam3; i<=szam2;i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write($"{i} ");
                        db++;
                    }
                }
                Console.Write($"Összesen {db} páros szám van!");
            }
            else
            {               
                Console.Write($"{szam2};{szam3} intervallumban a páros számok: ");
                int db = 0;
                for (int i = szam2;i<=szam3;i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write($"{i} ");
                        db++;
                    }
                }
                Console.Write($"Összesen {db} páros szám van!");
            }
            
            Console.ReadKey();
        }
    }
}
