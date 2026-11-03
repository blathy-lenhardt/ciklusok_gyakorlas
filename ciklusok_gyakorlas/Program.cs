using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciklusok_gyakorlas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. feladat
            // Állítsunk elő véletlenszerűen öt egész számot a [0,50]-ból, és írjuk ki a képernyőre egymás mellé 5 karakternyi helyet lefoglalva a számoknak!
            Console.WriteLine("1. feladat");
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                Console.Write("{0,5}", rand.Next(0, 51));
            }
            Console.WriteLine();

            // 2. feladat
            // Állítsunk elő véletlenszerűen 40 egész számot a [-100,100]-ból, és írjuk ki a képernyőre egymás mellé 6 karakternyi helyet lefoglalva,
            //  de egy sorban csak 8 szám legyen! A kiírás végén adjuk meg hány darab pozitív szám van!
            Console.WriteLine("2. feladat");
            int num;
            ushort positives = 0;
            for (int i = 0; i < 40/8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    num = rand.Next(-100, 101);
                    if (num >= 0)
                        positives++;
                    Console.Write("{0,6}", num);
                }
                Console.WriteLine();
            }
            Console.WriteLine("{0}db pozitív szám van.", positives);
        }
    }
}
