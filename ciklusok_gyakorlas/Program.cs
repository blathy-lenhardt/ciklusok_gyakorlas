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
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                Console.Write("{0,5}", rand.Next(0, 51));
            }
            Console.WriteLine();
        }
    }
}
