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

            // 3. feladat
            /* Kérjünk be egy számot és írjuk ki, hogy az prímszám-e vagy sem!
                Az algoritmus hatékony alakja: 
                    Be: szam
                    prim := igaz
                    Ha ((szam < 2) vagy (szam MOD 2 = 0)) és (szam <> 2) akkor prim := hamis
                    különben
                        i := 3
                        Ciklus amíg ((i <= gyök(szam)) és (prim = igaz))
                            Ha (szam MOD i = 0) akkor prim = hamis
                                i = i + 2
                        Ciklus vége
                    Elágazás vége
                    Ha (prim = igaz) akkor Ki: "prímszám"
                           különben Ki: "nem prímszám"
                    Elágazás vége
            */
            Console.WriteLine("3. feladat");
            int szam;
            bool prim = true;
            Console.Write("Adjon meg egy számot: ");
            szam = Convert.ToInt32(Console.ReadLine());
            if (((szam < 2) || (szam % 2 == 0)) && (szam != 2))
                prim = false;
            else
            {
                int i = 3;
                while ((i <= Math.Sqrt(szam)) && (prim == true))
                {
                    if (szam % i == 0)
                        prim = false;
                    i += 2;
                }
            }
            if (prim)
                Console.WriteLine("Prímszám");
            else
                Console.WriteLine("Nem prímszám");

            // 4. feladat
            // Kérjünk be egy mobil telefonszámot (06, +36 utáni részt), és csak akkor fogadjuk el, ha az valóban mobilszám!
            //  Írjuk ki, hogy a szám melyik szolgáltatóhoz tartozik! (20 - Yettel, 30 - Telekom, 70 - Vodafone)
            Console.WriteLine("4. feladat");
            string phone_number;
            ushort provider_num;
            Console.Write("Adja meg a telefonszámot (xx/xxxxxxx): ");
            phone_number = Console.ReadLine();
            provider_num = (ushort)((phone_number[0] - '0') * 10);
            provider_num += (ushort)(phone_number[1] - '0');
            switch (provider_num)
            {
                case 20:
                    Console.WriteLine("Yettel");
                    break;
                case 30:
                    Console.WriteLine("Telekom");
                    break;
                case 70:
                    Console.WriteLine("Vodafone");
                    break;
                default:
                    Console.WriteLine("Ismeretlen szolgáltató");
                    break;
            }

            // 5. feladat
            // Készítsen programot, ami számokat kér be mindaddig, amíg 0-át nem adunk meg!
            Console.WriteLine("5. feladat");
            ushort num5;
            do
            {
                num5 = Convert.ToUInt16(Console.ReadLine());
            } while (num5 != 0);

            // 6. feladat
            // Készítsen programot, ami számokat kér be mindaddig, amíg az utolsó két szám meg nem egyezik!
            Console.WriteLine("6. feladat");
            ushort num6 = 0, tmp;
        get_tmp: tmp = Convert.ToUInt16(Console.ReadLine());
            if (tmp != num6)
            {
                num6 = tmp;
                goto get_tmp;
            }

            // 7. feladat
            /* Készítsen számkitaláló programot! A gép véletlenszerűen találjon ki egy számot 1 és 100 között!
             *  A felhasználótól kérjen be tippeket, és mondja meg, hogy a gondolt szám a tipptől nagyobb-e vagy kisebb!
             *  A tippelés addig megy, amíg a felhasználó el nem találta a megadott számot.
             */
            Console.WriteLine("7. feladat");
            ushort random_num = (ushort)rand.Next(1, 101);
            ushort guess;
            uint guesses = 0;
        guess: Console.Write("Adj meg egy számot: ");
            guess = Convert.ToUInt16(Console.ReadLine());
            guesses++;
            if (guess != random_num)
            {
                if (guess < random_num)
                    Console.WriteLine("A gondolt szám nagyobb mint a(z) {0}", guess);
                else
                    Console.WriteLine("A gondolt szám kisebb mint a(z) {0}", guess);
                goto guess;
            }
            Console.WriteLine("Kitaláltad {0} tippből, a megoldás {1}", guesses, random_num);
        }
    }
}
