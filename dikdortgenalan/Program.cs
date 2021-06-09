using System;

namespace dikdortgenalan
{
    class Program
    {
        static void Main(string[] args)
        {
            int kisa, uzun, alan, cevre;

            Console.Write("Kısa Kenar : ");
            kisa = Convert.ToInt32(Console.ReadLine());

            Console.Write("Uzun Kenar : ");
            uzun = Convert.ToInt32(Console.ReadLine());

            alan = kisa * uzun;

            cevre = 2 * (kisa + uzun);

            Console.WriteLine("Alan :{0} ", alan);
            Console.WriteLine("Çevre :{0} " , cevre);
            Console.ReadKey();
        }
    }
}
