using System.ComponentModel.Design;

namespace Studycase18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan sebuah angka: ");
            int angka = Convert.ToInt32(Console.ReadLine());

            if (angka > 0)
            {
                Console.WriteLine("Bilangan positif.");
            }
            else if (angka < 0)
            {
                Console.WriteLine("Bilangan negatif.");
            }
            else
            {
                Console.WriteLine("Nol.");










            }
        }
    }
}