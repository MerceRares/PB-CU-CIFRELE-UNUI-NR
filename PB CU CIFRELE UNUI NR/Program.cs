using System;
using System.Net.Http.Headers;

namespace PB_CU_CIFRELE_UNUI_NR
{
    /// <summary>
    /// PB CU NR/CIFRELE UNUI NR
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());//citirea unui numar

            n = GetIntFromConsole();


            ///calculez suma cifrelor numarului:

            Console.WriteLine($"Suma cifrelor numarului {n} este {SumaCifre(n)}");///val din acolade sunt calculate
          
        }
        private static int SumaCifre(int n)
        {
            int suma = 0;//acumulator
            int cifra;
            while(n>0)
            {
                cifra = n % 10;///se da ultima cifra a numarului 123/10 => 12, 123 %10 => 3
                suma += cifra;//echivalent cu suma = suma + cifra;
                n = n / 10;//echivalent cu n/=10
                //12.34/10=1.234
            }//instructiunile se pot executa niciodata
            return suma;
         }
        private static int GetIntFromConsole()
        {
            string line;
            int n=0;
            bool flag;///fanion
            do
            {
                flag = true;
                Console.WriteLine("Introduceti un numar intreg");
                line = Console.ReadLine();//citire de la consola pe line

                try
                {
                    n = int.Parse(line);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Ati introdus o secventa care nu e numar");
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine(ex.Message);
                    flag = false;
                }
                if(!flag)
                    Console.WriteLine("Mai incercati odata");
                while (!flag) ;///operator de negatie   !flase==>true,  !true==>false
            } while (true);//instructiunile se repeta la infinit
            return n;
        }
    }
}
      