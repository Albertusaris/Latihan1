using System;

namespace PRG2_20192_P1_3_02
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Program menulis syair lagu'Anak Ayam' ");
            Console.Write("Masukan banyak anak ayam : ");
            int n = Convert.ToInt16(Console.ReadLine());
            for (int i = n; i > 0; i--)
            {
                if (i >= 2)
                {
                    Console.WriteLine("Anak ayam turun {0},mati satu tinggal {1}", i, i-1);
                }
                else
                {
                    Console.WriteLine("Anak ayam turun {0},mati satu tinggal induknya", i);
                }

            }



           Console.ReadKey();


        }
   
    }
}
