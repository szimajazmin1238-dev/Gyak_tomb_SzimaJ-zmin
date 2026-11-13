using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] szamok = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < szamok.Length; i++)
                szamok[i] = rnd.Next(0,101);
            szamok = int.Parse(szamok);
            int parosDb = 0;
            int paratlan = 0;

            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] / 2 == 0)
                {
                    parosDb++;
                }
                else
                {
                    paratlan++;
                }
            }

            
            Console.WriteLine($"paros szamok: {parosDb}");
            Console.WriteLine($"paratlan szamok: {paratlan}");


            Console.ReadKey();
        }
    }
}
