using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elsogitrepo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Állítsunk elő véletlenszerűen 40 egész számot a [-100,100]-ból, 
            //és írjuk ki a képernyőre egymás mellé! A kiírás végén adjuk meg hány darab pozitív szám van!

            Console.WriteLine("40 véletlen szám -100 és 100 között: ");
            Random rnd = new Random();
            int[] szamok = new int[40];
            int pozitiv = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rnd.Next(-100, 100);
                Console.Write(szamok[i] + "; ");
                if (szamok[i] > 0)
                {
                    pozitiv++;
                }
            }
            Console.WriteLine("\nÖsszesen: {0}db pozitív szám van benne", pozitiv);
            Console.WriteLine("Program Vége");
            Console.ReadKey();

        }
    }
}
